using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SesameApiClient.Models
{
    public class SesameBaseResponseModel
    {
        public string device_id { get; set; }
        public string serial { get; set; }
        public string nickname { get; set; }
    }

    public class SesameStatusResponseModel
    {
        public bool locked { get; set; }
        public int battery { get; set; }
        public bool responsive { get; set; }
    }

    public class SesameControlResponseModel
    {
        public string task_id { get; set; }
    }

    public class SesameTaskResponseModel
    {
        public string status { get; set; }
        public bool successful { get; set; }
        public string error { get; set; }
    }
}
