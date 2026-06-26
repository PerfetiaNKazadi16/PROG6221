using SecureBotWPF;
using System;
using System.Collections.Generic;
using System.Windows;
namespace SecureBotWPF
{
   
      


 
        public class Chatbot
        {
            private Random random = new Random();

            // MEMORY
            private string favoriteTopic = "";
            private string lastTopic = "";

            // KEYWORD RESPONSES
            private Dictionary<string, List<string>> responses =
                new Dictionary<string, List<string>>()
            {
            {
                "password",
                new List<string>()
                {
                    "Use strong passwords with uppercase, lowercase, numbers, and symbols.",
                    "Avoid using personal information in your passwords.",
                    "Use a different password for every account."
                }
            },

            {
                "phishing",
                new List<string>()
                {
                    "Be careful of suspicious emails asking for personal information.",
                    "Always verify email senders before clicking links.",
                    "Scammers often pretend to be trusted companies."
                }
            },

            {
                "privacy",
                new List<string>()
                {
                    "Review your privacy settings regularly.",
                    "Avoid sharing sensitive information publicly online.",
                    "Enable two-factor authentication to improve your privacy."
                }
            },

            {
                "malware",
                new List<string>()
                {
                    "Install antivirus software to protect against malware.",
                    "Avoid downloading files from unknown websites.",
                    "Keep your software updated to reduce malware risks."
                }
            },

            {
                "wifi",
                new List<string>()
                {
                    "Public WiFi can be unsafe for sensitive activities.",
                    "Avoid online banking on public WiFi networks.",
                    "Use a VPN when connecting to public WiFi."
                }
            },

            {
                "vpn",
                new List<string>()
                {
                    "A VPN encrypts your internet connection.",
                    "VPNs improve privacy on public networks.",
                    "Using a VPN helps protect your online data."
                }
            },

            {
                "scam",
                new List<string>()
                {
                    "Never share banking details with unknown people.",
                    "Online scammers often create fake urgency.",
                    "Be cautious of offers that sound too good to be true."
                }
            }
            };

            public string GetResponse(string input, User user)
            {
                input = input.ToLower();

                // EMPTY INPUT
                if (string.IsNullOrWhiteSpace(input))
                {
                    return "Please type something.";
                }

                // GREETING
                if (input.Contains("hello") || input.Contains("hi"))
                {
                    return $"Hello {user.Name}! How can I help you today?";
                }

                // EXIT
                if (input.Contains("bye") || input.Contains("exit"))
                {
                    return $"Goodbye {user.Name}! Stay safe online.";
                }

                // MEMORY FEATURE
                if (input.Contains("i like"))
                {
                    favoriteTopic = input.Replace("i like", "").Trim();

                    return $"Great! I'll remember that you're interested in {favoriteTopic}.";
                }

                // RECALL MEMORY
                if (input.Contains("what do i like"))
                {
                    if (favoriteTopic != "")
                    {
                        return $"You told me that you're interested in {favoriteTopic}.";
                    }

                    return "You haven't shared your favourite cybersecurity topic yet.";
                }

                // FOLLOW-UP CONVERSATION
                if (input.Contains("tell me more") ||
                    input.Contains("another tip") ||
                    input.Contains("explain more"))
                {
                    if (lastTopic != "")
                    {
                        return GetRandomResponse(lastTopic);
                    }

                    return "Please tell me which cybersecurity topic you want to know more about.";
                }

                // SENTIMENT DETECTION
                if (input.Contains("worried"))
                {
                    return "It's understandable to feel worried about online threats. Here is a tip: Never click suspicious links from emails or messages.";
                }

                if (input.Contains("frustrated"))
                {
                    return "Cybersecurity can feel overwhelming sometimes, but learning step by step helps a lot.";
                }

                if (input.Contains("curious"))
                {
                    return "Curiosity is a great way to learn cybersecurity. Feel free to ask more questions.";
                }

                // KEYWORD RECOGNITION
                foreach (var keyword in responses.Keys)
                {
                    if (input.Contains(keyword))
                    {
                        lastTopic = keyword;

                        return GetRandomResponse(keyword);
                    }
                }

                // DEFAULT RESPONSE
                return $"I'm not sure I understand, {user.Name}. Try asking about passwords, phishing, malware, scams, VPNs, WiFi, or privacy.";
            }

            // RANDOM RESPONSE METHOD
            private string GetRandomResponse(string keyword)
            {
                List<string> possibleResponses = responses[keyword];

                int index = random.Next(possibleResponses.Count);

                return possibleResponses[index];
            }
        }
    }

