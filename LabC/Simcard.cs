using System.Collections.Generic;

namespace LabC
{
    class Simcard
    {
        public Simcard()
        {
            simcardTypes = new List<string>() { "Standard SIM", "Micro SIM", "Nano SIM" };
        }

        public bool ESim
        {
            get { return eSim; }
            set { eSim = value; }
        }

        public string SimType
        {
            get { return simType; }
            set
            {
                if (simcardTypes.Contains(value))
                {
                    simType = value;
                }
                else
                {
                    Error.Show(value);
                }
            }
        }

        private string simType;
        private bool eSim;
        private List<string> simcardTypes;

    }
}