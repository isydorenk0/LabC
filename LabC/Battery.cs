using System.Collections.Generic;

namespace LabC
{
    class Battery
    {
        public Battery()
        {
            batteryTypes = new List<string>() { "Li-Ion", "Li-Po" };
        }
        public bool Builtin
        {
            get { return builtin; }
            set { builtin = value; }
        }

        public bool Wirelesschrg
        {
            get { return wirelesschrg; }
            set { wirelesschrg = value; }
        }
        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public string BatType
        {
            get { return batType; }
            set
            {
                if (batteryTypes.Contains(value))
                {
                    batType = value;
                }
                else
                {
                    Error.Show(value);
                }
            }
        }

        private bool builtin;
        private bool wirelesschrg;
        private int capacity;
        private string batType;
        private List<string> batteryTypes;
    }
}