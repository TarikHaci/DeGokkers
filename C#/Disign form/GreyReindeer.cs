using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DeGokkers
{
    public enum Position { first, second, third, fourth, none };


    public class GreyReindeer
    {
        //PROPERTIES
        public int RaceTrackLegth; // De lengte van de renbaan
        public PictureBox MyPictureBox = null;
        public Random Randomizer; //Een instantie van Random (= Willekeurig)
        private bool isFinish;
        private Position position;
        private Label lblFinish;
        //CONSTRUCTOR
        public GreyReindeer(PictureBox mypicturebox, Label lblFinish)
        {
            this.MyPictureBox = mypicturebox;
            isFinish = false;
            position = Position.none;
            this.lblFinish = lblFinish;
        }

        //METHODS
        public void Run(Random random)
        {

            if (MyPictureBox.Left <= 685)
            {
                MyPictureBox.Left += random.Next(1, 4);
            }


        }
        public void TakeStartingPosition()
        {
            MyPictureBox.Left = 0;
            isFinish = false;
            position = Position.none;
            RefreshLabel();
            MyPictureBox.Image = Properties.Resources.Reindeergif_transparant;
            //MyPictureBox.BackColo;
        }

        public bool IsFinish()
        {
            return isFinish;
        }
        public int GetLeftPosition()
        {
            return MyPictureBox.Left;
        }
        public void SetFinish()
        {
            MyPictureBox.Image = Properties.Resources.reindeergifStatic;
            isFinish = true;
        }
        public Position GetPosition()
        {
            return position;
        }
        public void SetPosition(Position p)
        {
            position = p;
        }
        public void RefreshLabel()
        {
            switch (position)
            {
                case Position.first :
                    lblFinish.Text = "Eerste";
                        break;
                case Position.second :
                        lblFinish.Text = "Tweede";
                        break;
                case Position.third :
                        lblFinish.Text = "Derde";
                        break;
                case Position.fourth :
                        lblFinish.Text = "Vierde";
                        break;
                default:
                        lblFinish.Text = "- - - -";
                        break;

            }
        }

    }
}
