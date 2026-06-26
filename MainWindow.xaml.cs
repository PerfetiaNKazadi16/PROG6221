using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System;
using System.Windows.Documents;


namespace SecureBotWPF
{
  
    public partial class MainWindow : Window
    {
         

        private Chatbot chatbot= new Chatbot();
        private User user = new User();
        private bool waitingForName = true;
        private QuizManager qm= new QuizManager();
        public MainWindow()
        {
            
            InitializeComponent();
            txtChat.Text = "Bot: Hello welcome to securebot your cybersecurity chat bot.\n" +
                "Bot:What is your name?";
            VoiceGreeting.PlayGreeting();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string input = message_txt.Text;

            if (string.IsNullOrWhiteSpace(input))
            {
                MessageBox.Show("Please type a message.");
                return;

            }
           
            txtChat.Text = "You:" + input + "\n";
            if (waitingForName)
            {
                user.Name = input;
                txtChat.Text += "Bot: Nice to meet you," + user.Name + "!\n" +
                    "Bot: Ask me anything about cybersecurity.\n\n";
                waitingForName = false;
                message_txt.Clear();
                return;
            }
            string response = chatbot.GetResponse(input, user);
            txtChat.Text += "Bot:" + response + "\n\n";

            message_txt.Clear();

        }
         
        private void btnAddTask_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Add Task clicked");
        }

        private void btnViewTasks_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("View Tasks clicked");
        }

        
        private void btnQuiz_Click(object sender, RoutedEventArgs e)

        {
            qm.StartQuiz();
            QuizQuestion question= qm.GetCurrentQuestion();
            
            if (question != null)
            {
                txtChat.Text += "\nBot:" + question.Question + "\n";
                qm.Next();
            }
            else { txtChat.Text = "\nBot: No more questions.\n"; }
        }

        private void btnLog_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Activity Log clicked");
        }



    }
}