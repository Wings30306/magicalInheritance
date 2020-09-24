using System;

namespace MagicalInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Storm storm = new Storm("Zul'rajas", false, "wind");
            Console.WriteLine(storm.Announce());
        }
    }
}
