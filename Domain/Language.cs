using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lingowords.Domain
{
    public class Word
    {
        public string word { get;}
        public int length { get; }
        public string lang { get; }

        public Word(string _word)
        {
            word = _word;
        }

        public Word(string _word, int _length, string _lang)
        {
            word = _word;
            length = _length;
            lang = _lang;
        }
    }
}
