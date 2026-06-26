using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureBotWPF
{
    public class ActivityLogger
    {
        private List<string> logs = new List<string>();

        public void AddLog(string action)
        {
            logs.Add(
                $"{DateTime.Now}: {action}"
            );
        }

        public List<string> GetRecentLogs()
        {
            return logs.TakeLast(10).ToList();
        }
    }
}