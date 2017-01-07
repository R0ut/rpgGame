using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA22_RPG
{
    class HumanAttack : IAttack
    {
        private PictureBox picHuman;
        private PictureBox picMonster;
        private ProgressBar progMonster;
        private ProgressBar progHuman;
        private int attackPower = 0; // change when u pick up some other weapon
        private Items item = new Items(2, true);
        public int numberOfKilled { get; private set; } //number of killed monster 1-bat, 2-ghost, 3-ghoul
        

        public HumanAttack(PictureBox picHuman,PictureBox picMonster ,ProgressBar progHuman, ProgressBar progMonster, int attackPower,int numberOfMonster)
        {
            this.picHuman = picHuman;
            this.picMonster = picMonster;
            this.progHuman = progHuman;
            this.progMonster = progMonster;
            this.attackPower = attackPower;
            this.numberOfKilled = numberOfMonster;
        }

        public void Attack()
        {
            if (IsEnable() && !IsDeath() && attackPower != 0)
            {
               // progMonster.Value -= attackPower;
                item.WeaponOrHeal(progHuman, progMonster);
            }
        }

        public bool IsEnable()
        {
            int LocationX = 0;
            int LocationY = 0;

            LocationX = picHuman.Location.X;
            LocationY = picHuman.Location.Y;

            if (LocationX == picMonster.Location.X && LocationY == picMonster.Location.Y)
                return true;
            else
            return false;
        }
        
        public bool IsDeath()
        {
            if (progMonster.Value == 0)
                return true;
            else
                return false;
        }

        public void PickUpItem(int NumberOfItem) // 0 - bow 1-mace, 2-potblue ,3-potred ,4-sword
        {

        }

      
    }
}
