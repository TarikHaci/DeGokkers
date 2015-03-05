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
        Guy[] guyArray = new Guy[3];
        int dogFinished;
        public FormRenbaan()
        {
            InitializeComponent();
            InitDogs();
            InitGuys();
            dogFinished = 0;
        }

        private void wedt_Click(object sender, EventArgs e)
        {
            if (wedtEuro.Value >= 5 && hondNummer.Value > 0 && deelnemer1.Checked)
            {
                Weddenschap1.Text = ("Sietse wedt " + wedtEuro.Value + " Euro op rendier nummer " + hondNummer.Value);
            }
            else if (wedtEuro.Value >= 5 && hondNummer.Value > 0 && deelnemer2.Checked)
            {
                weddenschap2.Text = ("Lidy wedt " + wedtEuro.Value + " Euro op rendier nummer " + hondNummer.Value);
            }
            else if (wedtEuro.Value >= 5 && hondNummer.Value > 0 && deelnemer3.Checked)
            {
                weddenschap3.Text = ("Fer wedt " + wedtEuro.Value + " Euro op rendier nummer " + hondNummer.Value);
            }
            else if (wedtEuro.Value < 5)
            {
                MessageBox.Show("Minimaal vanaf 5 euro!");
            }
            else if (hondNummer.Value <= 0)
            {
                MessageBox.Show("Kies een rendier nummer!");
            }
            else
            {
                MessageBox.Show("Kies een deelnemer!");
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
            ReindeerArray[0] = new GreyReindeer(dier1, lblfinish1);
            ReindeerArray[1] = new GreyReindeer(dier2, lblfinish2);
            ReindeerArray[2] = new GreyReindeer(dier3, lblfinish3);
            ReindeerArray[3] = new GreyReindeer(dier4, lblfinish4);
        }
        public void InitGuys()
        {
            guyArray[0] = new Guy(50, "Sietse", lblSietseCash);
            guyArray[1] = new Guy(75, "Lidy", lblLidyCash);
            guyArray[2] = new Guy(45, "Fer", lblFerCash);
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
    }
}
