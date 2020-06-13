using System;
using System.Drawing;
using System.Linq;

namespace LabC
{

    class BodyBasic
    {
        public BodyBasic()
        {
            colors = Enum.GetNames(typeof(KnownColor));
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
        private double width;
        private double height;
        private double depth;
        private double weight;
        private string color;
        private string[] colors;
    }

    class Flip : BodyBasic
    {
        private string flip = "This is a flip phone";
    }
    class Bar : BodyBasic
    {
        private string bar = "This is a bar phone";
    }

}