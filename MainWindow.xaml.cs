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
        public MainWindow()
        {
            
            InitializeComponent();
            txtChat.Text =
                 "Bot: Hello welcome to securebot your cybersecurity chat bot.\n" + "Bot:What is your name?";
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
      
    }
}