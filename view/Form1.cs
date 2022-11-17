using Game_Kursak_Admin.controller;
using System;
using System.Windows.Forms;

namespace Game_Kursak_Admin
{
    public partial class Form1 : Form
    {
        Controller controller = new Controller();

        public Form1()
        {
            InitializeComponent();
        }

        private void start_server_btn_Click(object sender, EventArgs e)
        {
            controller.StartServer(this, stop_server_btn, start_server_btn);
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            controller.RefreshClients(listBox1, listBox2);
        }

        private void stop_server_btn_Click(object sender, EventArgs e)
        {
            controller.StopServer(this, stop_server_btn, start_server_btn);
        }
    }
}
