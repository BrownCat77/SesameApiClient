using System.Net.Http;

using SesameApiClient.Entities;

namespace SesameApiClient.Http
{
    public abstract class HttpRequestForSesame : HttpRequestBase
    {
        public HttpRequestForSesame(ConnectionEntity connection) : base(connection)
        {
        }
    }

    #region デバイスリスト取得
    public class HttpRequest_GetSesameList : HttpRequestForSesame
    {
        public HttpRequest_GetSesameList(ConnectionEntity connection) : base(connection)
        {
            AddHeader_Authorization(connection.Token);
        }

        protected override HttpMethod GetMethod()
        {
            return HttpMethod.Get;
        }

        protected override string GetAction()
        {
            return "sesames";
        }
    }
    #endregion


    #region デバイスステータス取得
    public class HttpRequest_GetSesameStatus : HttpRequestForSesame
    {
        public HttpRequest_GetSesameStatus(ConnectionEntity connection) : base(connection)
        {
            AddHeader_Authorization(connection.Token);
        }

        public void SetDeviceId(string id)
        {
            DeviceId = id;
        }

        protected override HttpMethod GetMethod()
        {
            return HttpMethod.Get;
        }

        protected override string GetAction()
        {
            return "sesame";
        }
    }
    #endregion

    #region コマンド実行
    public class HttpRequest_ControlSesame : HttpRequestForSesame
    {
        public HttpRequest_ControlSesame(ConnectionEntity connection) : base(connection)
        {
            AddHeader_Authorization(connection.Token);
        }

        public void SetDeviceId(string id)
        {
            DeviceId = id;
        }

        public void SetParam(string command)
        {
            SetData(new { command = command });
        }

        protected override HttpMethod GetMethod()
        {
            return HttpMethod.Post;
        }

        protected override string GetAction()
        {
            return "sesame";
        }
    }
    #endregion

    #region コマンド結果問い合わせ
    public class HttpRequest_QueryExecutionResult : HttpRequestForSesame
    {
        public HttpRequest_QueryExecutionResult(ConnectionEntity connection) : base(connection)
        {
            AddHeader_Authorization(connection.Token);
        }

        public void SetParam(string task_id)
        {
            SetData(new { task_id = task_id });
        }

        protected override HttpMethod GetMethod()
        {
            return HttpMethod.Get;
        }

        protected override string GetAction()
        {
            return "action-result";
        }
    }
    #endregion
}
