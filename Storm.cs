using System;

namespace MagicalInheritance
{
    class Storm
    {
        public string Essence
        {
            get;
            private set;
        }

        public bool IsStrong
        {
            get;
            private set;
        }

        public string Caster
        {
            get;
            private set;
        }

        public Storm(string caster, bool isStrong, string essence)
        {
            this.Essence = essence;
            this.IsStrong = isStrong;
            this.Caster = caster;
        }

        public string Announce()
        {
            string force = IsStrong ? "strong" : "weak";
            return $"{Caster} cast a {force} {Essence} storm!";
        }
    }
}
