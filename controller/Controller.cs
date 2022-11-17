using Game_Kursak_Admin.model;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Game_Kursak_Admin.controller
{
    internal class Controller
    {
        MyServer server = new MyServer();

        public void StopServer(Form1 form1, Button btn_stop_server, Button btn_start_server)
        {
            server.CloseServer();
            form1.BackColor = Color.Red;
            btn_stop_server.Enabled = false;
            btn_start_server.Enabled = true;
        }

        public void StartServer(Form1 form1, Button btn_stop_server, Button btn_start_server)
        {
            btn_stop_server.Enabled = true;
            btn_start_server.Enabled = false;

            try
            {
                Thread thread = new Thread(new ThreadStart(server.Listen));
                thread.Start();
                form1.BackColor = Color.Green;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                server.CloseServer();
            }
        }

        public void RefreshClients(ListBox listBox, ListBox listBox2)
        {
            try
            {
                listBox.Items.Clear();
                foreach (var item in server.clients)
                {
                    listBox.Items.Add(item.Name + " - ID: " + item.Id + "; IP: " + item.GetLocalIpAddress());
                }
                listBox2.Items.Add(server.msg);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
