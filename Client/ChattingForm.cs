using ChatLib.Handlers;
using ChatLib.Sockets;
using ChatLib.Models;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using SuggestedWord;
using WaitingRoom;
using Vote;
using Krypton.Toolkit;

namespace WinFormClient
{
    public partial class ChattingForm : KryptonForm
    {
        ChatClient _client;
        ClientHandler _clientHandler;
        string _userName;

        private int m = 0;
        private int s = 30;

        public ChattingForm(ChatClient client, ClientHandler handler, string userName)
        {
            InitializeComponent();
            _client = client;
            _clientHandler = handler;
            _userName = userName;
        }

        // �޽����� ������ �޼���
        private void sendBtn_Click(object sender, EventArgs e)
        {
            string msg = txtInput.Text;
            if (!string.IsNullOrWhiteSpace(msg))
            {
                chatPanel.Controls.Add(new MyChat(msg));
                txtInput.Text = "";

                _clientHandler.Send(new ChatHub
                {
                    UserName = _userName,
                    Message = msg,
                });

            }
        }

        public void AddOtherChat(string msg, string user)
        {
            chatPanel.Controls.Add(new OtherChat(msg, user));
        }

        private void UItimer_Tick(object sender, EventArgs e)
        {
            if (s == 0)
            {
                if (m == 0)
                {
                    gTimer.Stop();
                    BeginInvoke((MethodInvoker)delegate
                    {
                        var voteForm = new Vote_form();
                        voteForm.Show();
                        this.Hide();
                    });
                    return;
                }
                m--;
                s = 59;
            }
            else
            {
                s--;
            }
            UpdateTimeLabel();
        }

        private void UpdateTimeLabel()
        {
            timeLbl.Text = $"{m:D2}:{s:D2}";
        }

        private void ChattingForm_Load(object sender, EventArgs e)
        {
            gTimer.Start();
        }
        
        public void setWord(string word)
        {
            wordLbl.Text = word;
        }
    }
}