using System;
using System.Collections.Generic;

namespace Cryptograph
{
    [Serializable]
    public class Alphabet
    {
        public string Name { get; set; }
        public string Letters { get; set; }

        public Alphabet() { }

        public Alphabet(string Name, string Letters) 
        {
            this.Name = Name;
            this.Letters = Letters;
        }
    }

    [Serializable]
    public class Alphabets
    {
        public List<Alphabet> ListOfAlphabets { get; set; }

        public Alphabets() { }

        public Alphabets (List<Alphabet> alphabets)
        {
            this.ListOfAlphabets = alphabets;
        }
    }
}
