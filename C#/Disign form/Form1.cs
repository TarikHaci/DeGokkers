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
        public Form1()
        {
            InitializeComponent();
            InitDogs();
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
                Weddenschap1.Text = ("Sietse wedt "+ wedtEuro.Value + " Euro op rendier nummer " + hondNummer.Value);
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
            for (int i = 0; i < dogArray.Length; i++)
            {
                dogArray[i].Run(rand);
            }
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            tmrDog.Enabled = true;
        }
        public void InitDogs()
        {
            dogArray[0] = new GreyReindeer(dier1);
            dogArray[1] = new GreyReindeer(dier2);
            dogArray[2] = new GreyReindeer(dier3);
            dogArray[3] = new GreyReindeer(dier4);
        }

    }
}