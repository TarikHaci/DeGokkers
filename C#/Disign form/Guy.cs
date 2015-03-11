using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DeGokkers
{
    public class Guy
    {
        //FIELDS
        private string Name;
        public Bet MyBet;
        public Label MyLabel;
        public int Cash;
        public RadioButton myRadioButton;
        public TextBox myTextBox;

        //CONSTRUCTOR
        public Guy(int Cash, string Name, Label MyLabel, RadioButton myRadioButton, TextBox myTextBox)
        {

            this.Name = Name;
            this.MyLabel = MyLabel;
            this.Cash = Cash;
            this.myRadioButton = myRadioButton;
            this.myTextBox = myTextBox;
            UpdateLabels();
        }



        public int GetCash()
        {
            return Cash;
        }
        public void SetCash(int cash)
        {
            Cash = cash;
            if (MyLabel != null)
                MyLabel.Text = Cash.ToString();
        }

        



        public void UpdateLabels()
        {
            MyLabel.Text = Cash.ToString();
        }

        public bool PlaceBet(int amount, int dog)
        {
            UpdateLabels();
            return true;
        }

        public void ClearBet()
        {
            // Maakt de weddenschapsveld leeg.
        }

        public void Collect(int Winner)
        {
            UpdateLabels();
            // Betaalt mijn weddenschap uit.
            // Maakt mijn weddenschapsveld leeg.
            // Werkt mijn labels bij.
        }
        public string GetName()
        {
            return Name;
        }
    }
}
