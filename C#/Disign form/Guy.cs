using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Disign_form
{
    public class Guy
    {
        //FIELDS
        public string Name;
        public Bet MyBet;
        public int Cash;
        public Label MyLabel;

        public int cash
        {
            get { return Cash; }
            set
            {
                Cash = value;
                if (MyLabel != null)
                    MyLabel.Text = Cash.ToString();
            }
        }


        //CONSTRUCTOR
        public Guy(int Cash, string Name, Label MyLabel)
        {

            this.Name = Name;
            this.MyLabel = MyLabel;
            this.cash = Cash;
        }



        public void UpdateLabels()
        {
            MyLabel.Text = Cash.ToString();

        }

        public bool PlaceBet(int amount, int dog)
        {

            return true;
        }

        public void ClearBet()
        {
            // Maakt de weddenschapsveld leeg.
        }

        public void Collect(int Winner)
        {
            // Betaalt mijn weddenschap uit.
            // Maakt mijn weddenschapsveld leeg.
            // Werkt mijn labels bij.
        }
    }
}
