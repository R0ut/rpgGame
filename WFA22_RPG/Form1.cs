using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Dodac progres bar na humanem i dac kolor czerwony tła tego progresbara
/// zalatwione poruszanie teraz atak 
/// </summary>


namespace WFA22_RPG
{
    public partial class Form1 : Form
    {
        MoveHuman moveHuman;
        MoveMonster moveMonster;
        HumanAttack humanAttack;
        ProgressBar monsterBar;
        PictureBox monsterPic;
        PictureBox picItem;
        ItemsViasble itemV;
        Random rand;
        int round = 0;
        private string[] tabPicture = { "pictureBoxBowItem", "pictureBoxMaceItem", "pictureBoxSwordItem", "pictureBoxPotionBlueItem", "pictureBoxPotionRedItem"};
        public Form1()
        {
            InitializeComponent();
            monsterBar = progressBarBat;
            monsterPic = pictureBoxBat;
            buttonDown.Text = char.ConvertFromUtf32(8595);
            buttonUp.Text = char.ConvertFromUtf32(8593);
            buttonLeft.Text = char.ConvertFromUtf32(8592);
            buttonRight.Text = char.ConvertFromUtf32(8594);
            moveHuman = new MoveHuman(progressBarHuman);
            moveMonster = new MoveMonster(pictureBoxPlayer,progressBarBat);
            humanAttack = new HumanAttack(pictureBoxPlayer, monsterPic,progressBarHuman, monsterBar, 1, 2);
            itemV = new ItemsViasble();
           
            
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            moveHuman.Move(pictureBoxPlayer,progressBarHuman, 1);
            moveMonster.Move(monsterPic, monsterBar, 0);
            round++;
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            moveHuman.Move(pictureBoxPlayer,progressBarHuman, 2);
            moveMonster.Move(monsterPic, monsterBar, 0);
            round++;
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            moveHuman.Move(pictureBoxPlayer,progressBarHuman, 4);
            moveMonster.Move(monsterPic, monsterBar, 0);
            round++;
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            moveHuman.Move(pictureBoxPlayer,progressBarHuman, 3);
            moveMonster.Move(monsterPic, monsterBar, 0);
            round++;
        }

        private void buttonAttack_Click(object sender, EventArgs e)
        {
            humanAttack.Attack();
            moveMonster.Move(monsterPic, monsterBar, 0);
            round++;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (round % 6 == 0)
            {
                rand = new Random();
                int a = rand.Next(4);
                picItem = new PictureBox();
               // picItem.Name = itemV.ItemNumberName(a);
                //picItem.Visible = true;

                // trzeba zeobic zeby pokazywal picturebox
                // itemV.ItemNumberName zwraca stringa pictureboxbatitem itd...
                // 
            }

            if (humanAttack.IsDeath() && humanAttack.numberOfKilled == 2)
            {
                humanAttack = new HumanAttack(pictureBoxPlayer, pictureBoxGhost,progressBarHuman, progressBarGhost, 2, 3);
                pictureBoxGhost.Visible = true;
                progressBarGhost.Visible = true;
                pictureBoxBat.Visible = false;
                progressBarBat.Visible = false;
                monsterPic = pictureBoxGhost;
                monsterBar = progressBarGhost;
            }
            else if (humanAttack.IsDeath() && humanAttack.numberOfKilled == 3)
            {
                humanAttack = new HumanAttack(pictureBoxPlayer, pictureBoxGhoul, progressBarHuman, progressBarGhoul, 4, 4);
                pictureBoxGhoul.Visible = true;
                progressBarGhoul.Visible = true;
                pictureBoxGhost.Visible = false;
                progressBarGhost.Visible = false;
                monsterPic = pictureBoxGhoul;
                monsterBar = progressBarGhoul;
            }
            else if (humanAttack.IsDeath() && humanAttack.numberOfKilled == 4)
            {
                timerGame.Stop();
                MessageBox.Show("Win");
                pictureBoxGhoul.Visible = false;
                progressBarGhoul.Visible = false;

            }
               

        }

       
    }
}
