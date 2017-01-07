using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA22_RPG
{
    interface IAttack
    {
        bool IsEnable();
        void Attack();
    }
}
