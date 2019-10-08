using System;

namespace phone
{
    public class Galaxy: Phone, IRingable
    {
        public string RingTone
        {
            get
            {
                return _ringTone;
            }
        }
        public Galaxy(string versionNumber, int batterPercentage, string carrier, string ringTone) : base(versionNumber, batterPercentage, carrier, ringTone)
        {

        }
        public string Ring()
        {
            System.Console.WriteLine($"...{_ringTone}...");
            return $"{_ringTone}";
        }
        public string Unlock()
        {
            System.Console.WriteLine($"Galaxy {_versionNumber} unlocked with fingerprint scanner!");
            return $"Galaxy {_versionNumber} unlocked with fingerprint scanner!";
        }
        public override void DisplayInfo()
        {
            System.Console.WriteLine("############");
            System.Console.WriteLine($"Phone: Galaxy {_versionNumber}");
            System.Console.WriteLine($"Battery Percentage: {_batteryPercentage}");
            System.Console.WriteLine($"Carrier: {_carrier}");
            System.Console.WriteLine($"Ring Tone: {_ringTone}");
            System.Console.WriteLine("############");
        }
    }
}