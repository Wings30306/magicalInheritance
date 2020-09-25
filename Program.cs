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
        }
    }
}
