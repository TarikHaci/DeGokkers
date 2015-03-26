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
        public string Name { get; private set;}
        public Bet MyBet;
        public Label MyLabel;
        public int _Cash;
        public int Cash
        {
            get { return _Cash; }
            set
            {
                _Cash = value;
                MyLabel.Text = value + "€";
            }
        }
        public RadioButton myRadioButton;
        public TextBox myTextBox;
        public bool HaveBet;

        //CONSTRUCTOR
        public Guy(int Cash, string Name, Label MyLabel, RadioButton myRadioButton, TextBox myTextBox)
        {
            HaveBet = false;
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
            //MyLabel.Text = Cash.ToString();
        }

        public bool PlaceBet(int amount, Reindeer Reindeer)
        {
            UpdateLabels();
            
            if (amount <= Cash)
            {
                MyBet = new Bet(amount, Reindeer, this);
                HaveBet = true;
                Cash -= amount;
                myRadioButton.Enabled = false;
                myRadioButton.Checked = false;
                return true;
            }

           return false;
        }

        public void ClearBet()
        {
            myTextBox.Text = Name + " heeft nog geen weddenscap geplaatst";
            HaveBet = false;
        }

        public void Collect(int Winner)
        {
            UpdateLabels();
            // Betaalt mijn weddenschap uit.
            // Maakt mijn weddenschapsveld leeg.
            // Werkt mijn labels bij.
        }
    }
}
