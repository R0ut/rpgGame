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
        private PictureBox human, p1i, p2i, p3i, p4i, p5i, p1l, p2l, p3l, p4l, p5l;  //p1i sword, p2i bow, p3i mace, p4i potion blue,p5i potion red  and them are items on board
                                                                              // the same as up p1l, p2l, p3l, p4l, p5l ther`s one are on list  
        public ItemsViasble(PictureBox human, PictureBox p1i, PictureBox p2i, PictureBox p3i, PictureBox p4i, PictureBox p5i, PictureBox p1l, PictureBox p2l, PictureBox p3l, PictureBox p4l, PictureBox p5l)
        {
            this.p1i = p1i;
            this.p2i = p2i;
            this.p3i = p3i;
            this.p4i = p4i;
            this.p5i = p5i;
            this.p1l = p1l;
            this.p2l = p2l;
            this.p3l = p3l;
            this.p4l = p4l;
            this.p5l = p5l;
            this.human = human;
        }

        private bool isOnItem(PictureBox p)
        {
            if (p.Visible == true)
            {
                int Xposition = human.Location.X - p.Location.X;
                int Yposition = human.Location.Y - p.Location.Y;

                bool IsNegativeX = Xposition < 0;
                bool IsNegativeY = Yposition < 0;

                if (IsNegativeX) Xposition *= -1;
                if (IsNegativeY) Yposition *= -1;

                if (Xposition <= 5 && Xposition >= 0 || Yposition <= 5 && Yposition >= 0)
                    return true;
                else return false;
            }
            return false;
        }
       
        private void setVisableItem()
        {
            if (random() == 0)  p1i.Visible = true;
            else if (random() == 1) p2i.Visible = true;
            else if (random() == 2) p3i.Visible = true;
            else if (random() == 3) p4i.Visible = true;
            else if (random() == 4) p5i.Visible = true;
        }


        private void setItemVisableOnList() // set visable items on list if character stand at item
        {
            if (isOnItem(p1i))
            {
                p1l.Visible = true;
                p1i.Visible = false;
            }
            else if (isOnItem(p2i))
            {
                p2l.Visible = true;
                p2i.Visible = false;
            }
            else if (isOnItem(p3i))
            {
                p3l.Visible = true;
                p3i.Visible = false;
            }
            else if (isOnItem(p4i))
            {
                p4l.Visible = true;
                p4i.Visible = false;
            }
            else if (isOnItem(p5i))
            {
                p5l.Visible = true;
                p5i.Visible = false;
            }
        }
        public void CheckNumberOfMove(int round)
        {
            setItemVisableOnList();
            if (round % 12 == 0)
            {
                setVisableItem();                
            }
        }
      

        private int random()
        {
            Random r = new Random();
            return r.Next(5);
        }
    }
}
