using System;

namespace MagicalInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil pupil = new Pupil("Mezil-Kree");
            Storm storm = pupil.CastWindStorm();
            Console.WriteLine(storm.Announce());

            Mage mage = new Mage("Gul'dan");
            Storm mageRainStorm = mage.CastRainStorm();
            Console.WriteLine(mageRainStorm.Announce());
            Storm mageWindStorm = mage.CastWindStorm();
            Console.WriteLine(mageWindStorm.Announce());
        }
    }
}
