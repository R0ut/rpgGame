using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA22_RPG
{
    interface IMove
    {
        void Move(PictureBox picture, ProgressBar bar, int direction);
        bool EnableMove(PictureBox picture, ProgressBar bar);
    }
}
