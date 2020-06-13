using System;
using System.Collections.Generic;

namespace LabC
{
class DisplayBasic
    {
        public DisplayBasic()
        {
            panelTypes = new List<string>() { "OLED", "AMOLED", "LCD" };
            Pixels = new Resolution();
        }

        public double Diagonal
        {
            get { return diagonal; }
            set { diagonal = value; }
        }

        public Resolution Pixels
        {
            get { return pixels; }
            set { pixels = value; }
        }

        public string Type
        {
            get { return type; }
            set
            {
                if (panelTypes.Contains(value))
                {
                    type = value;
                }
                else
                {
                    Error.Show(value);
                }
            }
        }

        private double diagonal;
        private Resolution pixels;
        private string type;
        private List<string> panelTypes;
    }

    internal class Resolution
    {
        public int Horizontal
        {
            get { return horizontal; }
            set { horizontal = value; }
        }
        public int Vertical
        {
            get { return vertical; }
            set { vertical = value; }
        }

        private int horizontal;
        private int vertical;
    }

    class BasicTouch : DisplayBasic
    {
        public void SoundOnTouch(bool beepb)
        {
            if (beepb)
            {
                Console.Beep();
            }
        }
        private void Haptics(string action)
        {
            switch (action)
            {
                case "Tap":
                    Console.WriteLine("Tap");
                    break;
                case "Press":
                    Console.WriteLine("Press");
                    break;
                default:
                    break;
            }
        }
    }

    class MultiTouch : BasicTouch
    {
        public override string ToString()
        {
            return "Multi touch";
        }        
    }
    class SingleTouch : BasicTouch
    {
        public override string ToString()
        {
            return "Single touch";
        }     
    }
}