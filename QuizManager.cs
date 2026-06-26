using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecureBotWPF
{
    public class QuizManager
    {
        private List<QuizQuestion> questions = new List<QuizQuestion>();
        private int currentIndex = 0;

        public QuizManager()
        {
            questions.Add(new QuizQuestion { Question = "What is phishing?", CorrectAnswer = "..." });
            questions.Add(new QuizQuestion { Question = "What is malware?", CorrectAnswer = "..." });
            questions.Add(new QuizQuestion { Question= "Can you share your password true or false", CorrectAnswer = "..." });
            questions.Add(new QuizQuestion { Question= "What is a strong password", CorrectAnswer= "..." });
        }

        public QuizQuestion GetCurrentQuestion()
        {
            if (currentIndex < questions.Count)
                return questions[currentIndex];

            return null;
        }

        public void Next()
        {
            currentIndex++;
        }

        public void StartQuiz()
        {
            currentIndex = 0;
        }
    }
}