using System;

namespace phone
{
    class Program
    {
        static void Main(string[] args)
        {
            Galaxy s8 = new Galaxy("s8", 100, "T-Mobile", "Do doo doo");
            Nokia elevenHundred = new Nokia("1100", 50, "Metro PCS", "Ringgg ring ring");
            s8.DisplayInfo();
            s8.Ring();
            s8.Unlock();
            elevenHundred.DisplayInfo();
            elevenHundred.Ring();
            elevenHundred.Unlock();
        }
    }
}
