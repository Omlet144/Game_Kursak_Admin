using Game_Kursak_Admin.model;
using Game_Kursak_Admin.model.DB_Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Game_Kursak_Admin.controller
{
    internal class Controller
    {
        MyServer server = new MyServer();
        AdminModel db = new AdminModel();
        List<Player_statistics_for_client> saveResults = new List<Player_statistics_for_client>();

        public void StopServer(Form1 form1, Button btn_stop_server, Button btn_start_server)
        {
            server.CloseServer();
            form1.BackColor = Color.Red;
            btn_stop_server.Enabled = false;
            btn_start_server.Enabled = true;
        }

        public void StartServer(Form1 form1, Button btn_stop_server, Button btn_start_server)
        {
            string json;
            btn_stop_server.Enabled = true;
            btn_start_server.Enabled = false;

            foreach (var item in db.Player_statistics)
            {
                saveResults.Add(new Player_statistics_for_client(item.PC_Name_And_ID.Name_PC, item.PC_Name_And_ID.Id_PC, item.Nick_name, item.Kills, item.Spent_ammo.Ammo_picked_up, item.Spent_ammo.Fired_bullets, item.Med_kit.Med_kit_picked_up, item.Med_kit.HP_replenishment_amount, item.Game_time));
            }

            json = JsonConvert.SerializeObject(saveResults, Formatting.Indented);
            try
            {
                server.msg = json;
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

        public void RefreshClients(List<SaveResult> list_result_client, DataGridView dataGridView_Results, DataGridView dataGridView_PC_Id_Name)
        {
            try
            {
                bool flag = true;
                dataGridView_PC_Id_Name.DataSource = server.clients;
                for (int i = 0; i < dataGridView_PC_Id_Name.RowCount; i++)
                {
                    dataGridView_PC_Id_Name.Rows[i].ReadOnly = true;
                }
                try
                {
                    foreach (var item in server.clients)
                    {
                        foreach (var item2 in db.Bans)
                        {
                            if (item2.PC_Name_And_ID.Id_PC == item.Id)
                            {
                                flag = false;
                                break;
                            }
                        }
                        if (flag == true)
                        {
                            AddToDB(list_result_client);
                        }
                    }
                    
                }
                catch
                {
                    MessageBox.Show("None new");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void AddToDB(List<SaveResult> list_result_client)
        {
            bool flag = false;
            string json = server.msg;
            list_result_client = JsonConvert.DeserializeObject<List<SaveResult>>(json);
            #region add_PC_Name_And_ID
            string id_pc = "";
            int id_PC_Name_ID = 0;
            foreach (var item_clients in server.clients)
            {
                id_pc = item_clients.Id;
                foreach (var item in db.PC_Name_And_ID)
                {
                    if (item.Id_PC == id_pc)
                    {
                        id_PC_Name_ID = item.Id;
                        break;
                    }
                }
                if (id_PC_Name_ID == 0)
                {
                    db.PC_Name_And_ID.Add(new PC_Name_And_ID() { Name_PC = item_clients.Name, Id_PC = item_clients.Id });
                    db.SaveChanges();
                }
            }

            #endregion
            #region add_Spent_ammo
            int ammo_picked_up = 0;
            int fired_bullets = 0;
            int id_Spent_ammo = 0;
            foreach (var item_spent_ammo_client in list_result_client)
            {
                ammo_picked_up = item_spent_ammo_client.client_Ammo_picked_up;
                fired_bullets = item_spent_ammo_client.client_Fired_bullets;
                foreach (var item in db.Spent_ammo)
                {
                    if (item.Ammo_picked_up == ammo_picked_up && item.Fired_bullets == fired_bullets)
                    {
                        id_Spent_ammo = item.ID;
                        break;
                    }
                }
                if (id_Spent_ammo == 0)
                {
                    db.Spent_ammo.Add(new Spent_ammo() { Ammo_picked_up = item_spent_ammo_client.client_Ammo_picked_up, Fired_bullets = item_spent_ammo_client.client_Fired_bullets });
                    db.SaveChanges();
                }
            }


            #endregion
            #region add_Med_kit
            int med_kit_picked_up = 0;
            int hP_replenishment_amount = 0;
            int id_Med_kit = 0;
            foreach (var item in list_result_client)
            {
                med_kit_picked_up = item.client_Med_kit_picked_up;
                hP_replenishment_amount = item.client_HP_replenishment_amount;
                foreach (var item2 in db.Med_kit)
                {
                    if (item2.Med_kit_picked_up == med_kit_picked_up && item2.HP_replenishment_amount == hP_replenishment_amount)
                    {
                        id_Med_kit = item2.ID;
                        break;
                    }
                }
                if (id_Med_kit == 0)
                {
                    db.Med_kit.Add(new Med_kit() { Med_kit_picked_up = item.client_Med_kit_picked_up, HP_replenishment_amount = item.client_HP_replenishment_amount });
                    db.SaveChanges();
                }

            }


            #endregion
            #region add_Player_statistics
            foreach (var item in list_result_client)
            {
                foreach (var item2 in db.Player_statistics)
                {
                    if (item2.PC_ID_And_Name_Id == id_PC_Name_ID)
                    {
                        if (item.client_Kills > item2.Kills)
                        {
                            item2.Nick_name = item.client_NickName;
                            item2.Kills = item.client_Kills;
                            item2.Spent_ammo_id = id_Spent_ammo;
                            item2.Med_kit_id = id_Med_kit;
                            item2.Weapon_id = 2;
                            item2.Game_time = item.client_Game_time;
                            // db.Entry(item2).State = EntityState.Modified;

                            flag = true;
                            break;
                        }
                        else
                        {
                            flag = true;
                            break;
                        }
                    }
                }
                db.SaveChanges();
                if (flag != true)
                {
                    db.Player_statistics.Add(new Player_statistics()
                    {
                        PC_ID_And_Name_Id = id_PC_Name_ID,
                        Nick_name = item.client_NickName,
                        Kills = item.client_Kills,
                        Spent_ammo_id = id_Spent_ammo,
                        Med_kit_id = id_Med_kit,
                        Weapon_id = 2,
                        Game_time = item.client_Game_time
                    });
                    db.SaveChanges();
                }
                else { break; }
            }

            #endregion
        }

        public void DeleteFromDB(string id_str)
        {
            try
            {
                int id = Convert.ToInt32(id_str);
                Player_statistics character = db.Player_statistics.Where(x => x.Id == id).FirstOrDefault();
                db.Player_statistics.Remove(character);
                db.SaveChanges();
            }
            catch { MessageBox.Show("Выберете ячейку с ID которую хотите удалить!"); }
        }

        public void DeleteFromBan(string id_str)
        {
            try
            {
                int id = Convert.ToInt32(id_str);
                Ban character = db.Bans.Where(x => x.Id == id).FirstOrDefault();
                db.Bans.Remove(character);
                db.SaveChanges();
            }
            catch { MessageBox.Show("Выберете ячейку с ID которую хотите удалить!"); }
        }

        public void ShowDB(DataGridView dataGridView_Results, DataGridView dataGridView_Ban)
        {
            try
            {
                dataGridView_Results.DataSource = db.Player_statistics.ToList();
                dataGridView_Ban.DataSource = db.Bans.ToList();
            }
            catch { MessageBox.Show("Cannot Show Table from DB"); }
        }

        public void AddToBan(DataGridView dataGridView_Ban, string id_str)
        {
            try
            {
                int id = Convert.ToInt32(id_str);
                foreach (var item in db.Player_statistics)
                {
                    if (item.PC_ID_And_Name_Id == id)
                    {
                        db.Bans.Add(new Ban() {PC_ID_And_Name_Id = id});
                    }
                }
                Player_statistics character = db.Player_statistics.Where(x => x.PC_ID_And_Name_Id == id).FirstOrDefault();
                db.Player_statistics.Remove(character);
                db.SaveChanges();
            }
            catch { MessageBox.Show("Выберете ячейку PC_Name_And_Id с  которую хотите удалить!"); }
        }

    }
}
