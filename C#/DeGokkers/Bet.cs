using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeGokkers
{
    public class Bet
    {
        #region Properties
        public int Amount; //Het bedrag van de weddenschap.
        public Reindeer Dog; //Het nummer van de hond waarop weddenschap is afgesloten.
        public Guy Bettor; //De gokker die gewed heeft.

        #endregion

        #region Constructor
        public Bet(int Amount, Reindeer Dog, Guy Bettor)
        {
            this.Amount = Amount;
            this.Dog = Dog;
            this.Bettor = Bettor;
        }
        #endregion
        


        public string GetDescription()
        {
            //Retourneer een string die aangeeft wie de weddenschap heeft gedaan,
            
            //voor welk bedrag er is gewed en op welke hond er is gewed.
            //Bijv. “Sietse wedt 8 euro op hond 4”.
            //Als het bedrag 0 is, is er geen weddenschap geplaatst.
            //De string die dan geretourneerd wordt is bijv.
            //“Sietse heeft geen weddenschap geplaatst.”)
            return Bettor.Name + " heeft " + Amount + " Euro op rendier " + Dog.GetName() + " gewed";
         }
        

        public void PayOut()
        {
            Bettor.Cash += Amount * 2;
        }
    }
}
