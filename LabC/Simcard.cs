using System.Collections.Generic;

namespace LabC
{
    class SimCardBasic
    {
        public bool Locked
        {
            get { return locked; }
            set { locked = value; }
        }
        private bool locked;
    }

    class ESimCard : SimCardBasic
    {
        public ESimCard()
        {
            carriers = new List<string>();
        }
        public void AddCarrier(string name)
        {
            carriers.Add(name);
        }
        public string ReturnCarrier(int ix)
        {
            if (ix <= carriers.Count)
            {
                return carriers[ix];
            }
            else
            {
                return "Our of range";
            }                      
        }
        private List<string> carriers;
    }
    class SimCard : SimCardBasic
    {
        public SimCard()
        {
            simcardTypes = new List<string>() { "Standard SIM", "Micro SIM", "Nano SIM" };
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
        public string Carrier
        {
            get { return carrier; }
            set { carrier = value; }
        }

        private string simType;
        private List<string> simcardTypes;
        private string carrier;
    }

}