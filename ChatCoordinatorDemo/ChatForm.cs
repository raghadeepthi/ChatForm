using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatCoordinatorDemo
{
    public partial class ChatForm : Form
    {
        public ChatForm()
        {
            InitializeComponent();
        }

        ChatCoordinator cc = ChatCoordinator.GetObject();

        private void ChatForm_Load(object sender, EventArgs e)
        {
            MessageHandler handler = new MessageHandler(RecievedMessage);
            cc.register(handler);
        }

        public void RecievedMessage(string Message)
        {
            txtRecieve.Text = Message;

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            cc.Broadcast(txtSend.Text);
        }

        
    }
}
