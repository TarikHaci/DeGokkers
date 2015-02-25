﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Disign_form
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        GreyReindeer[] dogArray = new GreyReindeer[4];
        Guy[] guyArray = new Guy[3];
        int dogFinished;
        public Form1()
        {
            InitializeComponent();
            InitDogs();
            InitGuys();
            dogFinished = 0;
        }

        private void deelnemer1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void wedtEuro_ValueChanged(object sender, EventArgs e)
        {

        }

        private void hondNummer_ValueChanged(object sender, EventArgs e)
        {

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
            if (CheckFinish())
            {
                for (int i = 0; i < dogArray.Length; i++)
                {
                    if (!dogArray[i].IsFinish())
                    {
                        dogArray[i].Run(rand);
                    }
                }
            }
            else
            {
                tmrDog.Enabled = false;
                MessageBox.Show("Ieder hond is gefinisht {0}", "hans peter");
                goButton.Enabled = true;
            }




            
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            goButton.Enabled = false;
            tmrDog.Enabled = true;
            for (int i = 0; i < dogArray.Length; i++)
            {
                dogArray[i].TakeStartingPosition();
            }
        }
        public void InitDogs()
        {
            dogArray[0] = new GreyReindeer(dier1);
            dogArray[1] = new GreyReindeer(dier2);
            dogArray[2] = new GreyReindeer(dier3);
            dogArray[3] = new GreyReindeer(dier4);
        }
        public void InitGuys()
        {
            guyArray[0] = new Guy(50, "Sietse", lblSietseCash);
            guyArray[1] = new Guy(75, "Lidy", lblLidyCash);
            guyArray[2] = new Guy(45, "Fer", lblFerCash);
        }
        public bool CheckFinish()
        {
            for (int i = 0; i < dogArray.Length; i++)
            {
                if (!dogArray[i].IsFinish())
                {
                    return true;
                }
            }
            return false;
        }
    }
}
