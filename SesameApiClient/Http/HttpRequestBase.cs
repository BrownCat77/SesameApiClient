using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;
using SesameApiClient.Entities;
using SesameApiClient.Exceptions;
using SesameApiClient.Utils;

namespace SesameApiClient.Http
{
    public abstract class HttpRequestBase
    {
        // HttpClientのコネクション開放問題に対応（詳細は以下を参照）
        // https://www.infoq.com/jp/news/2016/09/HttpClient
        private static HttpClient client = null;

        private string uri_base_str;
        private Dictionary<string, string> dict_header;         // Key, Value
        private Dictionary<string, string> dict_send_value;     // Key, Value

        protected string DeviceId = string.Empty;  //URLにIDとして埋め込むID（必要な場合のみ）

        public static void InitHttpClient(ConnectionEntity connection)
        {
            if (client != null)
            {
                client.Dispose();
                client = null;
            }

            client = new HttpClient();
            client.Timeout = TimeSpan.FromSeconds(ExternalParameter.ConnectionTimeoutSec);
        }

        public HttpRequestBase(ConnectionEntity connection)
        {
            if (client == null)
                InitHttpClient(connection);

            dict_header = new Dictionary<string, string>();
            dict_send_value = new Dictionary<string, string>();

            uri_base_str = connection.BaseUrl;
        }

        protected abstract HttpMethod GetMethod();
        protected abstract string GetAction();
        protected virtual string GetController()
        {
            return string.Empty;
        }

        protected virtual string GetUrlId(string id)
        {
            return string.Empty;
        }

        #region Create Http Content
        //Get用データ
        protected string CreateParamForGet()
        {
            List<string> tmp = new List<string>();
            foreach (var item in dict_send_value)
            {
                var key = item.Key;
                var value = item.Value;
                //Todo: UrlEncode
                tmp.Add(string.Format("{0}={1}", key, value));
            }

            return string.Join("&", tmp.ToArray());
        }

        //Post用データ
        protected HttpContent CreateJsonContentForPost()
        {
            //Keyが被るとたぶんエラーになる
            string json = JsonConvert.SerializeObject(dict_send_value);
            return new StringContent(json, Encoding.UTF8, ProjectUtility.ContentTypeJson);
        }
        #endregion

        #region For Normal Header
        protected void AddHeader_Authorization(string value)
        {
            AddNormalHeader("Authorization", value);
        }

        private void AddNormalHeader(string key, string value)
        {
            //後勝ち
            if (dict_header.ContainsKey(key))
                dict_header.Remove(key);

            dict_header.Add(key, value);
        }
        #endregion

        #region Set Data
        public void SetData(Object obj)
        {
            foreach (var item in GetDictionary(obj))
            {
                var key = item.Key;
                var value = item.Value;

                //後勝ち
                if (dict_send_value.ContainsKey(key))
                    dict_send_value.Remove(key);

                dict_send_value.Add(key, value);
            }
        }
        #endregion

        #region Send Request
        public bool SendRequest(out string body_str)
        {
            body_str = String.Empty;

            string uri_str = ProjectUtility.CreateUrlString(uri_base_str, GetController(), GetAction(), DeviceId);
            var request = CreateRequestMessage(GetMethod(), uri_str);

            bool ret = false;
            try
            {
                var response = client.SendAsync(request).Result;
                ret = response.IsSuccessStatusCode;

                body_str = response.Content.ReadAsStringAsync().Result;
                return ret;
            }
            catch (AggregateException)
            {
                string msg = "Connection failed.";
                throw new ServerAccessException(msg);
            }
        }

        private HttpRequestMessage CreateRequestMessage(HttpMethod method, string uri_str)
        {
            //Getの場合はパラメータをURLにつける
            if (method == HttpMethod.Get && dict_send_value.Count != 0)
                uri_str += ("?" + CreateParamForGet());

            var ret = new HttpRequestMessage(method, uri_str);

            //Postの場合は送信コンテンツを作成
            if (method == HttpMethod.Post)
                ret.Content = CreateJsonContentForPost();

            foreach (var item in dict_header)
            {
                ret.Headers.TryAddWithoutValidation(item.Key, item.Value);
            }

            return ret;
        }
        #endregion

        #region Utility
        private Dictionary<string, string> GetDictionary(Object obj)
        {
            Dictionary<string, string> ret = obj.GetType().GetProperties()
                .Where(p => p.CanRead).Select(p => new { name = p.Name, value = p.GetValue(obj) })
                .Where(p => p.value != null)
                .ToDictionary(p => p.name, p => p.value.ToString());

            return ret;
        }
        #endregion
    }
}
