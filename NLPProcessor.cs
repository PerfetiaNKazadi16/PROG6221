using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureBotWPF
{
    public class NLPProcessor
    {
        public string DetectIntent(string input)
        {
            input = input.ToLower();

            if (input.Contains("add task")
               || input.Contains("create task")
               || input.Contains("new task"))
            {
                return "ADD_TASK";
            }

            if (input.Contains("quiz")
               || input.Contains("game"))
            {
                return "QUIZ";
            }

            if (input.Contains("remind")
               || input.Contains("reminder"))
            {
                return "REMINDER";
            }

            if (input.Contains("activity log")
               || input.Contains("what have you done"))
            {
                return "LOG";
            }

            return "UNKNOWN";
        }
    }
}