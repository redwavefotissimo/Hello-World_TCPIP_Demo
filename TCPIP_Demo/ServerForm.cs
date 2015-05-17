using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using TCPManager;

namespace TCPIP_Demo
{
    public partial class ServerForm : Form
    {
        public ServerForm()
        {
            InitializeComponent();
        }

        private void BTNStart_Click(object sender, EventArgs e)
        {
            ServerAddress.Text = TCPIPController.GetServerMachineIPAddress().ToString();
            TCPIPController.StartListening(2055);
            Thread TCPServiceThread = new Thread(new ThreadStart(TCPIPController.Service));
            TCPServiceThread.Start();
        }

        private void BTNOpenClientForm_Click(object sender, EventArgs e)
        {
            Form CForm = new ClientForm();
            CForm.Show();
        }
    }
}
