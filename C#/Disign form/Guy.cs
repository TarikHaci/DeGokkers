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

        //CONSTRUCTOR
        public Guy(int Cash, string Name, Label MyLabel)
        {
            this.Cash = Cash;
            this.Name = Name;
            this.MyLabel = MyLabel;
        }



        public void UpdateLabels()
        {


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
