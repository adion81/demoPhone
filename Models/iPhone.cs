using System;
using demoPhone.Interfaces;

namespace demoPhone.Models
{
    public class iPhone : Phone, IRingable, ICamera
    {
        public int LensCount {get; set;}

        public int BatteryPercentage
        {
            get{
                return batteryPercentage;
            }
        }
        public iPhone(string versionNum, int batteryPerc, string ring, string carr) : base(versionNum,batteryPerc,ring,carr)
        {
            LensCount = 4;
        }
        public override void DisplayInfo()
        {

        }

        public override int Charge()
        {

            batteryPercentage += 10;
            return batteryPercentage;
        }

        public override bool HasJuice
        {
            get
            {
                return batteryPercentage >= 20;
            }
        }
        public string Ring()
        {
            if(HasJuice)
            {
                batteryPercentage -= 10;
                return ringTone;
            }
            else
            {
                batteryPercentage -= 5;
                return "Please charge your phone, Benny Bob.";
            }
        }

        public string Unlock()
        {
            return "Swipe to the right.";
        }

        public string Snap()
        {
            return "Nice Selfie!!! Looking good, yo.";
        }

        
    }
}