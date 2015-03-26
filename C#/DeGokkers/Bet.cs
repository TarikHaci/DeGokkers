using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeGokkers
{
    public class Bet
    {
        #region Properties
        public int amount; //Het bedrag van de weddenschap.
        public Reindeer reindeer; //Het nummer van de hond waarop weddenschap is afgesloten.
        public Guy bettor; //De gokker die gewed heeft.
        #endregion

        #region Constructor
        public Bet(int amount, Reindeer reindeer, Guy bettor)
        {
            this.amount = amount;
            this.reindeer = reindeer;
            this.bettor = bettor;
        }
        #endregion

        #region Methods
        public string GetDescription()
        {
            return bettor.name + " heeft " + amount + " Euro op rendier " + reindeer.GetName() + " gewed";
        }
        
        public void PayOut()
        {
            bettor.Cash += amount * 2;
        }
        #endregion
    }
}
