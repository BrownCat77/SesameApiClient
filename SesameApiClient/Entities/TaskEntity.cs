using System;

namespace SesameApiClient.Entities
{
    public class TaskEntity
    {
        public string task_id { get; set; }
        public string command { get; set; }
        public DateTime execution_date { get; set; }

        public bool has_result { get; set; }
        public string status { get; set; }
        public bool successful { get; set; }
        public string error { get; set; }

        public override string ToString()
        {
            var date = execution_date.ToString("HH:mm:ss");
            return String.Format("[{0}] {1}", date, command);
        }
    }
}
