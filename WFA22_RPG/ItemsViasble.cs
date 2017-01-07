using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA22_RPG
{
    class ItemsViasble
    {
        PictureBox p;

        public void ItemNumberName(int r)
        {
            
            if (r == 0 && p.Name == "pictureBoxBowItem") p.Visible = true;
            else if (r == 1 && p.Name == "pictureBoxMaceItem") p.Visible = true;
            else if (r == 2 && p.Name == "pictureBoxSwordItem") p.Visible = true;
            else if (r == 3 && p.Name == "pictureBoxPotionBlueItem") p.Visible = true;
            else if (r == 4 && p.Name == "pictureBoxPotionRedItem") p.Visible = true;
        }
    }
}
