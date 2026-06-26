using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureBotWPF
{
    class sentiment
    {
        public string DetectSentiment(string input)
        {
            input = input.ToLower();

            if (input.Contains("worried"))
                return "worried";

            if (input.Contains("scared"))
                return "worried";

            if (input.Contains("frustrated"))
                return "frustrated";

            if (input.Contains("curious"))
                return "curious";

            return "neutral";
        }
    }
}
    

