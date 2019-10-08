using System;

namespace phone
{
    public abstract class Phone{
        protected string _versionNumber;
        protected int _batteryPercentage;
        protected string _carrier;
        protected string _ringTone;
        public Phone(string versionNumber, int batterPercentage, string carrier, string ringTone)
        {
            _versionNumber = versionNumber;
            _batteryPercentage = batterPercentage;
            _carrier = carrier;
            _ringTone = ringTone;
        }
        public abstract void DisplayInfo();
    }
}