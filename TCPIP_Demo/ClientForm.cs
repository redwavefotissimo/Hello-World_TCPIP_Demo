using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TCPManager;

namespace TCPIP_Demo
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        private void BTNSend_Click(object sender, EventArgs e)
        {
            JobDescription.Text = TCPIPController.Client(textBox1.Text, 2055);
            
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
        }
    }
}
