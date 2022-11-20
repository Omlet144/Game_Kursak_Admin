using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Kursak_Admin.model
{
    public class SaveResult
    {
        public string NickName { get; set; }
        public int Kills { get; set; }
        public int Ammo_picked_up { get; set; }
        public int Fired_bullets { get; set; }
        public int Med_kit_picked_up { get; set; }
        public int HP_replenishment_amount { get; set; }
        public string Game_time { get; set; }

        public SaveResult()
        {
            this.NickName = "";
            this.Kills = 0;
            this.Ammo_picked_up = 0;
            this.Fired_bullets = 0;
            this.Med_kit_picked_up = 0;
            this.HP_replenishment_amount = 0;
            this.Game_time = "";
        }

        public SaveResult(string nickName, int kills, int ammo_picked_up, int fired_bullets, int med_kit_picked_up, int hP_replenishment_amount, string game_time)
        {
            this.NickName = nickName;
            this.Kills = kills;
            this.Ammo_picked_up = ammo_picked_up;
            this.Fired_bullets = fired_bullets;
            this.Med_kit_picked_up = med_kit_picked_up;
            this.HP_replenishment_amount = hP_replenishment_amount;
            this.Game_time = game_time;
        }
    }
}
