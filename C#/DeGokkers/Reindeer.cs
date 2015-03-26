using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DeGokkers
{
    public enum Position { first, second, third, fourth, none };
    public class Reindeer
    {
        #region Properties
        public int raceTrackLegth; // De lengte van de renbaan
        public PictureBox myPictureBox = null;
        public Random randomizer; //Een instantie van Random (= Willekeurig)
        private bool isFinish;
        private Position position;
        private Label lblFinish;
        private string name;
        #endregion 

        #region Constructor
        public Reindeer(PictureBox myPictureBox, Label lblFinish, string name)
        {
            this.myPictureBox = myPictureBox;
            this.name = name;
            isFinish = false;
            position = Position.none;
            this.lblFinish = lblFinish;
        }
        #endregion

        #region Methods
        public void Run(Random random)
        {
            if (myPictureBox.Left <= 685)
            {
                myPictureBox.Left += random.Next(1, 4);
            }
        }

        public void TakeStartingPosition()
        {
            myPictureBox.Left = 0;
            isFinish = false;
            position = Position.none;
            RefreshLabel();
            myPictureBox.Image = Properties.Resources.rendeergif2;
        }

        public void RefreshLabel()
        {
            switch (position)
            {
                case Position.first:
                    lblFinish.Text = "Eerste";
                    break;
                case Position.second:
                    lblFinish.Text = "Tweede";
                    break;
                case Position.third:
                    lblFinish.Text = "Derde";
                    break;
                case Position.fourth:
                    lblFinish.Text = "Vierde";
                    break;
                default:
                    lblFinish.Text = "- - - -";
                    break;
            }
        }
        #endregion

        #region Getter/Setter
        public bool IsFinish()
        {
            return isFinish;
        }

        public int GetLeftPosition()
        {
            return myPictureBox.Left;
        }

        public string GetName()
        {
            return name;
        }

        public void SetFinish()
        {
            myPictureBox.Image = Properties.Resources.rendeergif2static;
            myPictureBox.Left = 0;
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
        #endregion
    }
}
