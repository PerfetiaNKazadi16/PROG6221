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
        public MainWindow()
        {
            InitializeComponent();
            user.Name = "Perfetia";
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
            string response = chatbot.GetResponse(input, user);
            txtChat.Text += "Bot:" + response + "\n\n";

            message_txt.Clear();

        }
      
    }
}