using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DeGokkers
{
    public partial class FormRenbaan : Form
    {
        Random rand = new Random();
        GreyReindeer[] ReindeerArray = new GreyReindeer[4];
        Bet bet = new Bet();
        Guy[] guyArray = new Guy[3];
        int dogFinished;
        string name;
        public FormRenbaan()
        {
            InitializeComponent();
            PictureTransparator();
            InitDogs();
            InitGuys();
            dogFinished = 0;
        }

        private void wedt_Click(object sender, EventArgs e)
        {
            Guy bettor = getTheBettor();
            GreyReindeer ReindeerChoice = getTheReindeer();


            if (bettor.GetCash() >= wedtEuro.Value)
            {
                bettor.myTextBox.Text = bettor.GetName() + " wedt " + wedtEuro.Value + " op rendiernumer " + ReindeerChoice.GetName();
            }
        }

        private void tmrDog_Tick(object sender, EventArgs e)
        {
            if (dogFinished < 4)
            {
                for (int i = 0; i < ReindeerArray.Length; i++)
                {
                    if (!ReindeerArray[i].IsFinish())
                    {
                        ReindeerArray[i].Run(rand);
                    }
                    if (ReindeerArray[i].GetLeftPosition() >= 685 && !ReindeerArray[i].IsFinish())
                    {
                        
                        SetPosition(ReindeerArray[i]);
                        ReindeerArray[i].RefreshLabel();
                        ReindeerArray[i].SetFinish();
                        dogFinished++;
                    }
                }
            }
            else
            {
                tmrDog.Enabled = false;
                MessageBox.Show("Alle rendieren zijn gefinisht!");
                goButton.Enabled = true;
                dogFinished = 0;
            }
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            goButton.Enabled = false;
            tmrDog.Enabled = true;
            for (int i = 0; i < ReindeerArray.Length; i++)
            {
                ReindeerArray[i].TakeStartingPosition();
            }
        }
        public void InitDogs()
        {
            ReindeerArray[0] = new GreyReindeer(dier1, lblfinish1, "1");
            ReindeerArray[1] = new GreyReindeer(dier2, lblfinish2, "2");
            ReindeerArray[2] = new GreyReindeer(dier3, lblfinish3, "3");
            ReindeerArray[3] = new GreyReindeer(dier4, lblfinish4, "4");
        }
        public void InitGuys()
        {
            guyArray[0] = new Guy(50, "Sietse", lblSietseCash, deelnemer1, Weddenschap1);
            guyArray[1] = new Guy(75, "Lidy", lblLidyCash, deelnemer2, Weddenschap2);
            guyArray[2] = new Guy(45, "Fer", lblFerCash, deelnemer3, Weddenschap3);
        }
        public bool CheckFinish()
        {

                if (dogFinished == 4)
                {
                    return false;
                }
            
            return true;
        }
        public void SetPosition(GreyReindeer dog)
        {
            switch (dogFinished)
            {
                case 0:
                    dog.SetPosition(Position.first);
                    break;
                case 1:
                    dog.SetPosition(Position.second);
                    break;
                case 2:
                    dog.SetPosition(Position.third);
                    break;
                case 3:
                    dog.SetPosition(Position.fourth);
                    break;
                default:
                    break;
            }
        }

        private void deelnemer1_MouseClick(object sender, MouseEventArgs e)
        {
            if (deelnemer1.Checked)
            {
                lblNamePlayer.Text = deelnemer1.Text;
            }
            else if (deelnemer2.Checked)
            {
                lblNamePlayer.Text = deelnemer2.Text;
            }
            else
            {
                lblNamePlayer.Text = deelnemer3.Text;
            }
        }
        private void PictureTransparator()
        {
            //van stackoverflow
            Renbaan.Controls.Add(dier1);
            Renbaan.Controls.Add(dier2);
            Renbaan.Controls.Add(dier3);
            Renbaan.Controls.Add(dier4);
            dier1.BackColor = Color.Transparent;
            dier2.BackColor = Color.Transparent;
            dier3.BackColor = Color.Transparent;
            dier4.BackColor = Color.Transparent;
        }
        public Guy getTheBettor()
        {
            for (int i = 0; i < 3; i++)
            {
                if (guyArray[i].myRadioButton.Checked)
                {
                    return guyArray[i];
                }
            }
            return null;
        }
        public GreyReindeer getTheReindeer()
        {
            switch ((int)hondNummer.Value)
            {
                case 1:
                    return ReindeerArray[0];
                    break;
                case 2:
                    return ReindeerArray[1];
                    break;
                case 3:
                    return ReindeerArray[2];
                    break;
                case 4:
                    return ReindeerArray[3];
                    break;
                default:
                    break;
            }
            return null;
        }
    }
}
