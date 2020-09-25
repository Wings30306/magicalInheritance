// Archmage.cs
using System;

namespace MagicalInheritance
{
    class Archmage : Mage
    {
        public Archmage(string name) : base(name) { }

        public override Storm CastRainStorm()
        {
            Storm storm = new Storm(Title, true, "rain");
            return storm;
        }

        public Storm CastLightningStorm()
        {
            Storm storm = new Storm(Title, true, "lightning");
            return storm;
        }
    }
}