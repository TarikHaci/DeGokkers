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
            //Plaats een nieuwe weddenschap en sla het op in de variabele MyBet. 
    //Retourneer een true als de gokker genoeg geld heeft om te wedden.  
           //Onderstaande regel staat er tijdelijk om foutmeldingen te voorkomen.  
//Denk eraan dat weddenschappen gerepresenteerd worden door instanties van Bet. 
           //Haal deze regel later weg. 
           return true;
        }

        public void ClearBet()
        {
            myTextBox.Text = Name + " heeft nog geen weddenscap geplaatst";
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
