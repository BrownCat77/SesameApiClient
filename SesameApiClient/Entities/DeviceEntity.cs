using System;
using System.Collections.Generic;
using System.Linq;

namespace SesameApiClient.Entities
{
    public class DeviceEntity
    {
        public DeviceEntity()
        {
            task_list = new List<TaskEntity>();
        }

        public string device_id { get; set; }
        public string serial { get; set; }
        public string nickname { get; set; }

        public bool has_status { get; set; }
        public bool locked { get; set; }
        public int battery { get; set; }
        public bool responsive { get; set; }

        public List<TaskEntity> task_list { get; set; }

        public void AddTask(TaskEntity task)
        {
            task_list.Add(task);
            task_list = task_list.OrderByDescending(p => p.execution_date).ToList();
        }

        public override string ToString()
        {
            return String.Format("{0} [{1}]", nickname, serial);
        }
    }
}
