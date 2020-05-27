using System.Collections.Generic;

namespace LabC
{
    class Display
    {
        public Display()
        {
          panelTypes = new List<string>() { "OLED", "AMOLED", "LCD" };
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
        public bool Touch
        {
            get { return touch; }
            set { touch = value; }
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
        private bool touch;
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
}