using System;

namespace phone
{
    public class Nokia: Phone, IRingable
    {
        public string RingTone
        {
            get
            {
                return _ringTone;
            }
        }
        public Nokia(string versionNumber, int batterPercentage, string carrier, string ringTone) : base(versionNumber, batterPercentage, carrier, ringTone)
        {

        }
        public string Ring()
        {
            System.Console.WriteLine($"...{_ringTone}...");
            return $"{_ringTone}";
        }
        public string Unlock()
        {
            System.Console.WriteLine($"Nokia {_versionNumber} unlocked with passcode!");
            return $"Galaxy {_versionNumber} unlocked with passcode!";
        }
        public override void DisplayInfo()
        {
            System.Console.WriteLine("############");
            System.Console.WriteLine($"Phone: Nokia {_versionNumber}");
            System.Console.WriteLine($"Battery Percentage: {_batteryPercentage}");
            System.Console.WriteLine($"Carrier: {_carrier}");
            System.Console.WriteLine($"Ring Tone: {_ringTone}");
            System.Console.WriteLine("############");
        }
    }
}