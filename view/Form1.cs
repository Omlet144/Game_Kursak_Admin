using Game_Kursak_Admin.controller;
using Game_Kursak_Admin.model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Game_Kursak_Admin
{
    public partial class Form1 : Form
    {
        Controller controller = new Controller();
        public List<SaveResult> list_result_client = new List<SaveResult>();

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
            controller.RefreshClients(list_result_client, dataGridView_Results, dataGridView_PC_Id_Name);
            controller.ShowDB(dataGridView_Results, dataGridView_Bans);
        }

        private void stop_server_btn_Click(object sender, EventArgs e)
        {
            controller.StopServer(this, stop_server_btn, start_server_btn);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            controller.StopServer(this, stop_server_btn, start_server_btn);
            Application.Exit();

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
          
            try
            {
                controller.DeleteFromDB(dataGridView_Results.SelectedCells[0].Value.ToString());
            }
            catch
            {
                try 
                {
                    controller.DeleteFromBan(dataGridView_Bans.SelectedCells[0].Value.ToString());
                }
                catch 
                {
                    MessageBox.Show("Выберете ячейку с ID которую хотите удалить!"); 
                }
            }

            controller.ShowDB(dataGridView_Results, dataGridView_Bans);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            controller.ShowDB(dataGridView_Results, dataGridView_Bans);

        }

        private void button_ban_Click(object sender, EventArgs e)
        {
            string id = dataGridView_Results.SelectedCells[0].Value.ToString();
            controller.AddToBan(dataGridView_Bans, id);
        }
    }
}
