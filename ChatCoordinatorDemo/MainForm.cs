﻿using System;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnNewChatClient_Click(object sender, EventArgs e)
        {
            ChatForm frmchat = new ChatForm();
            frmchat.Show();
        }
      
    }
}
