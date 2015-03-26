using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DeGokkers
{
    public class Guy
    {
        #region Properties
        public string name { get; private set; }
        public Bet myBet;
        public Label myLabel;
        public int cash;
        public RadioButton myRadioButton;
        public TextBox myTextBox;
        public bool haveBet;
        #endregion

        #region Constructor
        public Guy(int cash, string name, Label myLabel, RadioButton myRadioButton, TextBox myTextBox)
        {
            haveBet = false;
            this.name = name;
            this.myLabel = myLabel;
            this.cash = cash;
            this.myRadioButton = myRadioButton;
            this.myTextBox = myTextBox;
        }
        #endregion

        #region Methods
        public bool PlaceBet(int amount, Reindeer Reindeer)
        {
            if (amount <= Cash)
            {
                myBet = new Bet(amount, Reindeer, this);
                haveBet = true;
                Cash -= amount;
                myRadioButton.Enabled = false;
                myRadioButton.Checked = false;
                return true;
            }
           return false;
        }

        public void ClearBet()
        {
            myTextBox.Text = name + " heeft nog geen weddenscap geplaatst";
            haveBet = false;
        }
        #endregion

        #region Getter/Setters
        public int Cash
        {
            get { return cash; }
            set
            {
                cash = value;
                myLabel.Text = "€" + value;
            }
        }
        #endregion
    }
}
