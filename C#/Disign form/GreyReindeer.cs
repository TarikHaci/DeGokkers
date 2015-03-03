using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Disign_form
{
    public enum Position { first, second, third, fourth };


    public class GreyReindeer
    {
        //PROPERTIES
        public int RaceTrackLegth; // De lengte van de renbaan
        public PictureBox MyPictureBox = null;
        public Random Randomizer; //Een instantie van Random (= Willekeurig)
        private bool isFinish;
        private Position position;
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
            else 
            {
                isFinish = true;
            }
                

        }
        public void TakeStartingPosition()
        {
            MyPictureBox.Left = 0;
            isFinish = false;


        }

        public bool IsFinish()
        {
            return isFinish;
        }
        public void SetPosition(Position position)
        {
            this.position = position;
        }
        public int GetLeftPosition()
        {
            return MyPictureBox.Left;
        }
    }
}
