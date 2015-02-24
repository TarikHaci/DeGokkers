using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Disign_form
{
    class GreyReindeer
    {
        //PROPERTIES
        public int RaceTrackLegth; // De lengte van de renbaan
        public PictureBox MyPictureBox = null;
        public Random Randomizer; //Een instantie van Random (= Willekeurig)
        private bool isFinish;

        //CONSTRUCTOR
        public GreyReindeer(PictureBox mypicturebox)
        {
            this.MyPictureBox = mypicturebox;
            isFinish = false;
        }

        //METHODS
        public void Run(Random random)
        {

            if (MyPictureBox.Left < 685)
            {
                MyPictureBox.Left += random.Next(1, 4);
            }

        }
        public void TakeStartingPosition()
        {
            if (isFinish)
            {
                MyPictureBox.Left = 0;
            }


        }
        public bool IsFinish()
        {
            if (!isFinish)
            {
                if (MyPictureBox.Left >= 685)
                {
                    isFinish = true;
                }
                else
                {
                    isFinish = false;
                }
            }

            if (isFinish)
                return false;

            else return true;
        }
    }
}
