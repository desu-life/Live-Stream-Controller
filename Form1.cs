using Live_Stream_Controller.Core;
using OBSWebsocketDotNet;
using OBSWebsocketDotNet.Types;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Live_Stream_Controller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void wsConnectButton_ClickAsync(object sender, EventArgs e)
        {
            if (await ObsBase.Connect(wstextbox.Text, wspwtextbox.Text))
            {
                toolStrip1.Enabled = false;
                statusLable.Text = "Connected.";
                return;
            }
            MessageBox.Show("Failed to connect to OBS.");
        }

        private void sponsorSourceSetButton_Click(object sender, EventArgs e)
        {
            Live_Stream_Controller.Controller.SourceCreator.CreateSponsorSourceAsync();
        }
    }
}
