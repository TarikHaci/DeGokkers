using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Disign_form
{
    class GreyReindeer
    {
        public int RaceTrackLegth; // De lengte van de renbaan
        public PictureBox MyPictureBox = null;
        public Random Randomizer; //Een instantie van Random (= Willekeurig)
        public GreyReindeer(PictureBox mypicturebox)
        {
            this.MyPictureBox = mypicturebox;
        }


        public void Run(Random random)
        {
            
            MyPictureBox.Left += random.Next(1, 4);
            
        }
        public void TakeStartingPosition()
        {
            // Wijzig mijn locatie naar de startlijn. 
        }
    }
}
