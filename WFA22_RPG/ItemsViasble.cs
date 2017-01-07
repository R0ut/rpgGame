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
        private PictureBox p1i, p2i, p3i, p4i, p5i, p1l, p2l, p3l, p4l, p5l;  //p1i sword, p2i bow, p3i mace, p4i potion blue,p5i potion red  and them are items on board
                                                                              // the same as up p1l, p2l, p3l, p4l, p5l ther`s one are on list  
        public ItemsViasble(PictureBox p1i, PictureBox p2i, PictureBox p3i, PictureBox p4i, PictureBox p5i, PictureBox p1l, PictureBox p2l, PictureBox p3l, PictureBox p4l, PictureBox p5l)
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
        }


        /// <summary>
        /// tutaj trzeba zmienić zeby itemy na liscie czyli p1l, p2l ... pojawiały sie tylko wtedy gdy gracz na nie najdzie dodac jeszcze jeden warunek
        /// </summary>
        private void setVisableItem()
        {

            if (random() == 0)
            {
                p1i.Visible = true;
                p1l.Visible = true;
            }
            else if (random() == 1)
            {
                p2i.Visible = true;
                p2l.Visible = true;
            }
            else if (random() == 2)
            {
                p3i.Visible = true;
                p3l.Visible = true;
            }
            else if (random() == 3)
            {
                p4i.Visible = true;
                p4l.Visible = true;
            }
            else if (random() == 4)
            {
                p5i.Visible = true;
                p5l.Visible = true;
            }
            
        }

        public void CheckNumberOfMove(int round)
        {
            if (round % 6 == 0)
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
