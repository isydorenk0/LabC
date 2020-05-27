namespace LabC
{
    class MobilePhone
    {
        public MobilePhone()
        {
            body = new Body();
            display = new Display();
            battery = new Battery();
        }

        public Body Body
        {
            get { return body; }
            set { body = value; }
        }

        public Display Display
        {
            get { return display; }
            set { display = value; }
        }
        public Battery Battery
        {
            get { return battery; }
            set { battery = value; }
        }
        public Simcard Simcard
        {
            get { return simcard; }
            set { simcard = value; }
        }

        private Body body;
        private Display display;
        private Battery battery;
        private Simcard simcard;
    }
}
