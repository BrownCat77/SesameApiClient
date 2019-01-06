using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SesameApiClient.Entities
{
    public class ConnectionEntity
    {
        public string BaseUrl { get; set; }
        public string Token { get; set; }

        public ConnectionEntity()
        {
            BaseUrl = String.Empty;
            Token = String.Empty;
        }
    }
}
