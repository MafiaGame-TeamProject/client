using ChatLib.Handlers;
using ChatLib.Models;
using ChatLib.Sockets;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using Krypton.Toolkit;
using WaitingRoom;
using SuggestedWord;
using Microsoft.VisualBasic.ApplicationServices;

namespace WinFormClient
{
    public partial class Init_form : KryptonForm
    {
        public static ChatClient? _client;
        private ClientHandler? _clientHandler;
        private waitingRoom_form waitingRoomForm;
        private ChattingForm chattingForm;

        private int RoomId => (int)nudRoomId.Value;
        private string UserName => txtName.Text;

        public Init_form()
        {
            InitializeComponent();

            _client = new ChatClient(IPAddress.Parse("127.0.0.1"), 8080);
            _client.Connected += Connected;
            _client.Disconnected += Disconnected;
            _client.Received += Received;
            _client.RunningStateChanged += RunningStateChanged;

            btnConnect.Click += BtnConnect_Click;
            btnStop.Click += BtnStop_Click;
        }

        private void RunningStateChanged(bool isRunning)
        {
            btnConnect.Enabled = !isRunning;
            btnStop.Enabled = isRunning;
        }

        private void Connected(object? sender, ChatLib.Events.ChatEventArgs e)
        {
            _clientHandler = e.ClientHandler;
            chattingForm = new ChattingForm(_client, _clientHandler, UserName);
        }

        private void Disconnected(object? sender, ChatLib.Events.ChatEventArgs e)
        {
            _clientHandler = null;
        }

        private void Received(object? sender, ChatLib.Events.ChatEventArgs e)
        {
            ChatHub hub = e.Hub;
            string message = hub.State switch
            {
                ChatState.Connect => $"{hub.UserName}님이 연결하였습니다.",
                ChatState.Disconnect => $"{hub.UserName}님이 연결을 끊었습니다.",
                _ => $"{hub.UserName}: {hub.Message}"
            };

            if (hub.Message.StartsWith("USER_LIST:"))
            {
                var users = hub.Message.Substring("USER_LIST:".Length).Split(',').ToList();
                if (waitingRoomForm == null || waitingRoomForm.IsDisposed)
                {
                    waitingRoomForm = new waitingRoom_form(_client, _clientHandler, UserName, chattingForm);
                    waitingRoomForm.UserInfo(RoomId, users);
                    waitingRoomForm.Show();
                    waitingRoomForm.FormClosing += waitingRoom_form_FormClosing!;
                    this.Hide();
                }
                else
                {
                    waitingRoomForm.UserInfo(RoomId, users);
                }
            }

            // WORD 메시지를 수신하면 suggestWord_form으로 전환
            if (hub.Message.StartsWith("WORD:"))
            {
                var word = hub.Message.Substring("WORD:".Length);
                BeginInvoke((MethodInvoker)delegate
                {
                    var suggestWordForm = new suggestWord_form(_client!, _clientHandler!, UserName, word, chattingForm);
                    suggestWordForm.Show();
                    waitingRoomForm.Hide();
                });
            }

            if (hub.Message.StartsWith("MESSAGE:"))
            {
                var _msg = hub.Message.Substring("MESSAGE:".Length);
                string[] msgArr = _msg.Split(':'); // msgArr[0] : UserName, msgArr[1] : Message

                if (msgArr[0] != UserName)
                {
                    chattingForm.AddOtherChat(msgArr[1], msgArr[0]);
                }
            }
        }

        private async void BtnConnect_Click(object? sender, EventArgs e)
        {
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("이름을 입력해주세요.");
                return;
            }

            await _client.ConnectAsync(new ConnectionDetails
            {
                RoomId = RoomId,
                UserName = UserName,
            });
        }

        private void BtnStop_Click(object? sender, EventArgs e)
        {
            _client.Close();
            this.Close();
        }

        private void waitingRoom_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            _client.Close();
            this.Close();
        }
        private void suggestWord_form_FormClosed(object sender, FormClosedEventArgs e)
        {
            _client.Close();
            this.Close();
        }
    }
}
