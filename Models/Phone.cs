namespace demoPhone.Models
{
    public abstract class Phone
    {
        protected string versionNumber;
        protected int batteryPercentage;
        protected string ringTone;
        protected string carrier;



        public abstract bool HasJuice{get;}

        public Phone(string versionNum, int batteryPerc, string ring, string carr)
        {
            versionNumber = versionNum;
            batteryPercentage = batteryPerc;
            ringTone = ring;
            carrier = carr;
        }

        public abstract void DisplayInfo();

        public abstract int Charge();
    }
}