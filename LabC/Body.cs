using System;
using System.Drawing;
using System.Linq;

namespace LabC
{
    class Body
    {
        public Body()
        {
           colors = Enum.GetNames(typeof(KnownColor));           
        }
        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public double Depth
        {
            get { return depth; }
            set { depth = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public string Color
        {
            get { return color; }
            set
            {
                if (colors.Any(value.Contains))
                {
                    color = value;
                }
                else
                {
                    Error.Show(value);                                   
                }
            }
        }

        private double width;
        private double height;
        private double depth;
        private double weight;
        private string color;
        private string[] colors;

    }
}