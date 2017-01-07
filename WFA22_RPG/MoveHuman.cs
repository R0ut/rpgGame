using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA22_RPG
{
    class MoveHuman : IMove
    {
        private ProgressBar bar;
        public MoveHuman(ProgressBar bar)
        {
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
                if (direction == 1)//Up
                {
                    picture.Top -= 10;
                    bar.Top -= 10;
                }
                if (direction == 2)//Down
                {
                    picture.Top += 10;
                    bar.Top += 10;
                }
                if (direction == 3)//Right
                {
                    picture.Left += 10;
                    bar.Left += 10;
                }
                if (direction == 4)//Left
                {
                    picture.Left -= 10;
                    bar.Left -= 10;
                }
            }
        }
    }
}
