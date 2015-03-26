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
        Reindeer[] ReindeerArray = new Reindeer[4];
        Guy[] guyArray = new Guy[3];
        int reindeerFinished = 0;

        public FormRenbaan()
        {
            InitializeComponent();
            PictureTransparator();
            InitReindeer();
            InitGuys();
        }

        private void wedt_Click(object sender, EventArgs e)
        {
            Guy bettor = getTheBettor();
            Reindeer ReindeerChoice = getTheReindeer();
            int amount = (int)wedtEuro.Value;

            if (bettor != null && bettor.PlaceBet(amount, ReindeerChoice))
            {
                bettor.myTextBox.Text = bettor.myBet.GetDescription();
            }
        }

        private void tmrReindeer_Tick(object sender, EventArgs e)
        {
            if (reindeerFinished < 4)
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
                        reindeerFinished++;
                    }
                }
            }
            else
            {
                //END OF THE RACE
                string endMessage = "Finish ! \n";
                //ReindeerArray.get
                for (int i = 0; i < guyArray.Length; i++)
                {
                    //check voor elke mensen als hij heeft gewedt of niet
                    if (guyArray[i].haveBet)
                    {
                        if (guyArray[i].myBet.reindeer.GetPosition() == Position.first)
                        {
                            guyArray[i].myBet.PayOut();
                            endMessage += guyArray[i].name + " heeft gewonnen !\n";
                        }
                        else
                        {
                            endMessage += guyArray[i].name + " heeft verloren !\n";
                        }
                        guyArray[i].myRadioButton.Enabled = true;
                    }
                }
                tmrReindeer.Enabled = false;
                //Alle rendieren zijn gefinisht!
                goButton.Enabled = true;
                wedtButton.Enabled = true;
                reindeerFinished = 0;
                guyArray[0].ClearBet();
                guyArray[1].ClearBet();
                guyArray[2].ClearBet();
                MessageBox.Show(endMessage);
            }
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            goButton.Enabled = false;
            wedtButton.Enabled = false;
            tmrReindeer.Enabled = true;
            for (int i = 0; i < ReindeerArray.Length; i++)
            {
                ReindeerArray[i].TakeStartingPosition();
            }
        }

        public void InitReindeer()
        {
            ReindeerArray[0] = new Reindeer(dier1, lblfinish1, "1");
            ReindeerArray[1] = new Reindeer(dier2, lblfinish2, "2");
            ReindeerArray[2] = new Reindeer(dier3, lblfinish3, "3");
            ReindeerArray[3] = new Reindeer(dier4, lblfinish4, "4");
        }

        public void InitGuys()
        {
            guyArray[0] = new Guy(50, "Sietse", lblSietseCash, deelnemer1, weddenschap1);
            guyArray[1] = new Guy(75, "Lidy", lblLidyCash, deelnemer2, weddenschap2);
            guyArray[2] = new Guy(45, "Fer", lblFerCash, deelnemer3, weddenschap3);
        }

        public bool CheckFinish()
        {
                if (reindeerFinished == 4)
                {
                    return false;
                }
            return true;
        }

        public void SetPosition(Reindeer dog)
        {
            switch (reindeerFinished)
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

        public Reindeer getTheReindeer()
        {
            switch ((int)hondNummer.Value)
            {
                case 1:
                    return ReindeerArray[0];
                case 2:
                    return ReindeerArray[1];
                case 3:
                    return ReindeerArray[2];
                case 4:
                    return ReindeerArray[3];
                default:
                    break;
            }
            return null;
        }
    }
}
