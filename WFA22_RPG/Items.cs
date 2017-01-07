using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA22_RPG
{
    class Items 
    {
        private int PowerAttack = 0;
        private bool IsWeapon;
      
        
        public Items(int PowerAttack,bool IsWeapon)
        {
            this.PowerAttack = PowerAttack;
            this.IsWeapon = IsWeapon;
            
        }

        private int UseItem()
        {
            if (IsWeapon) return -PowerAttack;
            else return PowerAttack;
        }

        public void WeaponOrHeal(ProgressBar barHuman,ProgressBar barMonser)
        {
            if (!IsWeapon) barHuman.Value += UseItem();
            else barMonser.Value += UseItem();
        }
       
    }
}
