// Pupil.cs
using System;

namespace MagicalInheritance
{
	class Pupil
    {
        public string Title
        {
            get;
            private set;
        }

        public Pupil(string name)
        {
            this.Title = name;
        }

        public Storm CastWindStorm()
        {
            Storm storm = new Storm(Title, false, "wind");
            return storm;
        }
    }
}
