// Mage.cs
using System;
using System.Reflection;

namespace MagicalInheritance
{
    class Mage : Pupil
    {
        public Mage(string name) : base(name)
        {}

        public Storm CastRainStorm()
        {
            Storm storm = new Storm(Title, false, "rain");
            return storm;
        }
    }
}
