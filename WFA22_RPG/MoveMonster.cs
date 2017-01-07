using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA22_RPG
{
    class MoveMonster : IMove
    {
        private PictureBox picHuman;
        private ProgressBar bar;
        public MoveMonster(PictureBox picHuman,ProgressBar bar)
        {
            this.picHuman = picHuman;
            this.bar = bar;
        }

        public bool EnableMove(PictureBox picture,ProgressBar bar)
        {
            if (picture.Location.X <= 76)
            {
                picture.Left += 10;
                bar.Left += 10;
                return false;
            }
            else if (picture.Location.X >= 475)
            {
                picture.Left -= 10;
                bar.Left -= 10;
                return false;
            }
            else if (picture.Location.Y >= 195)
            {
                picture.Top -= 10;
                bar.Top -= 10;
                return false;
            }
            else if (picture.Location.Y <= 57)
            {
                picture.Top += 10;
                bar.Top += 10;
                return false;
            }

            else return true;
        }

        public void Move(PictureBox picture, ProgressBar bar, int direction)
        {
            if (EnableMove(picture,bar) == true)
            {
                if (followHumam(picture) == 1)//Up
                {
                    picture.Top -= 10;
                    bar.Top -= 10;
                }
                if (followHumam(picture) == 2)//Down
                {
                    picture.Top += 10;
                    bar.Top += 10;
                }
                if (followHumam(picture) == 3)//Right
                {
                    picture.Left += 10;
                    bar.Left += 10;
                }
                if (followHumam(picture) == 4)//Left
                {
                    picture.Left -= 10;
                    bar.Left -= 10;
                }
            }
        }


        private int followHumam(PictureBox picture)
        {
            if(picHuman.Location.X < picture.Location.X) return 4;
            else if (picHuman.Location.X > picture.Location.X) return 3;
            else if (picHuman.Location.Y < picture.Location.Y) return 1;
            else if (picHuman.Location.Y > picture.Location.Y) return 2;
            return 0;

        }
    }
}
