using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace WFA22_RPG
{
    public partial class Form1 : Form
    {
        MoveHuman moveHuman;
        MoveMonster moveMonster;
        HumanAttack humanAttack;
        ProgressBar monsterBar;
        PictureBox monsterPic;
        ItemsViasble itemV;
        
        int round = 0;
        private List<PictureBox> listPicture = new List<PictureBox>();
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
            humanAttack = new HumanAttack(pictureBoxPlayer, monsterPic,progressBarHuman, monsterBar, 0, 2);
            itemV = new ItemsViasble(pictureBoxPlayer, pictureBoxSwordItem, pictureBoxBowItem, pictureBoxMaceItem, pictureBoxPotionBlueItem, pictureBoxPotionRedItem,
                pictureBoxSwordList,pictureBoxBowList,pictureBoxMaceList,pictureBoxPotionBlueList,pictureBoxPotionRedList);
            initList();
            
            pictureBoxPlayer.BringToFront();

    }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            moveHuman.Move(pictureBoxPlayer,progressBarHuman, 1);
            moveMonster.Move(monsterPic, monsterBar, 0);
            itemV.CheckNumberOfMove(round);
            round++;
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            moveHuman.Move(pictureBoxPlayer,progressBarHuman, 2);
            moveMonster.Move(monsterPic, monsterBar, 0);
            itemV.CheckNumberOfMove(round);
            round++;
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            moveHuman.Move(pictureBoxPlayer,progressBarHuman, 4);
            moveMonster.Move(monsterPic, monsterBar, 0);
            itemV.CheckNumberOfMove(round);
            round++;
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            moveHuman.Move(pictureBoxPlayer,progressBarHuman, 3);
            moveMonster.Move(monsterPic, monsterBar, 0);
            itemV.CheckNumberOfMove(round);
            round++;
        }

        private void buttonAttack_Click(object sender, EventArgs e)
        {
            humanAttack.Attack();
            moveMonster.Move(monsterPic, monsterBar, 0);
            itemV.CheckNumberOfMove(round);
            round++;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
           

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

        private void initList()
        {
            listPicture.Add(pictureBoxSwordList);
            listPicture.Add(pictureBoxBowList);
            listPicture.Add(pictureBoxMaceList);
            listPicture.Add(pictureBoxPotionBlueList);
            listPicture.Add(pictureBoxPotionRedList);
        }

        private void pictureBoxBowList_Click(object sender, EventArgs e)
        {
            foreach (PictureBox item in listPicture)
            {
                item.BorderStyle = BorderStyle.None;
            }
            pictureBoxBowList.BorderStyle = BorderStyle.Fixed3D;
        }

       
        private void pictureBoxMaceList_Click(object sender, EventArgs e)
        {
            foreach (PictureBox item in listPicture)
            {
                item.BorderStyle = BorderStyle.None;
            }
            pictureBoxMaceList.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBoxPotionBlueList_Click(object sender, EventArgs e)
        {
            foreach (PictureBox item in listPicture)
            {
                item.BorderStyle = BorderStyle.None;
            }
            pictureBoxPotionBlueList.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBoxPotionRedList_Click(object sender, EventArgs e)
        {
            foreach (PictureBox item in listPicture)
            {
                item.BorderStyle = BorderStyle.None;
            }
            pictureBoxPotionRedList.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBoxSwordList_Click(object sender, EventArgs e)
        {
            foreach (PictureBox item in listPicture)
            {
                item.BorderStyle = BorderStyle.None;
            }
            pictureBoxSwordList.BorderStyle = BorderStyle.Fixed3D;
        }
    }
}
