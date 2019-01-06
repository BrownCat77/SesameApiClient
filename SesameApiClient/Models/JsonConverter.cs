using Codeplex.Data;
using Microsoft.CSharp.RuntimeBinder;
using SesameApiClient.Exceptions;
using System.Collections.Generic;
using System.Xml;

namespace SesameApiClient.Models
{
    public static class JsonConverter
    {
        public static List<SesameBaseResponseModel> ParseSesameListResponse(string json_string)
        {
            var ret = new List<SesameBaseResponseModel>();

            try
            {
                var obj = Parse(json_string);
                foreach (var item in obj)
                {
                    ret.Add(new SesameBaseResponseModel
                    {
                        device_id = item.device_id,
                        serial = item.serial,
                        nickname = item.nickname,
                    });
                }
            }
            catch (RuntimeBinderException)
            {
                throw new ServerAccessException("[JSON] Missing required field.");
            }

            return ret;
        }

        public static SesameStatusResponseModel ParseSesameStatusResponse(string json_string)
        {
            var ret = new SesameStatusResponseModel();

            try
            {
                var obj = Parse(json_string);
                ret.locked = obj.locked;
                ret.battery = (int)obj.battery;
                ret.responsive = obj.responsive;
            }
            catch (RuntimeBinderException)
            {
                throw new ServerAccessException("[JSON] Missing required field.");
            }

            return ret;
        }

        public static SesameTaskResponseModel ParseSesameTaskQueryResponse(string json_string)
        {
            var ret = new SesameTaskResponseModel();

            try
            {
                var obj = Parse(json_string);
                ret.status = obj.status;
                ret.successful = obj.successful;

                if (!ret.successful)
                    ret.error = obj.error;
            }
            catch (RuntimeBinderException)
            {
                throw new ServerAccessException("[JSON] Missing required field.");
            }

            return ret;
        }


        public static SesameControlResponseModel ParseSesameControlResponse(string json_string)
        {
            var ret = new SesameControlResponseModel();

            try
            {
                var obj = Parse(json_string);
                ret.task_id = obj.task_id;
            }
            catch (RuntimeBinderException)
            {
                throw new ServerAccessException("[JSON] Missing required field.");
            }

            return ret;
        }

        private static dynamic Parse(string json_string)
        {
            try
            {
                return DynamicJson.Parse(json_string);
            }
            catch (XmlException)
            {
                throw new ServerAccessException("[JSON] Conversion failed.");
            }
        }
    }
}
