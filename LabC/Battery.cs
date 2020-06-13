using System.Collections.Generic;

namespace LabC
{
    class BatteryBasic
    {
        public bool Builtin
        {
            get { return builtinb; }
            set { builtinb = value; }
        }

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }
        public bool Wirelesschrg
        {
            get { return wirelesschrgb; }
            set { wirelesschrgb = value; }
        }

        private int capacity;
        private bool builtinb;
        private bool wirelesschrgb;
    }

    class LiIonBattery : BatteryBasic
    {
        public override string ToString()
        {
            return "Li-Ion Battery";
        }
    }
    class PoLiBattery : BatteryBasic
    {
        public override string ToString()
        {
            return "Po-Li Battery";
        }
    }
}