using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lingowords.Domain
{
    public class Word
    {
        public string Title { get;}
        public int Length { get; }
        public string Lang { get; }

        public Word(string _title)
        {
            Title = _title;
        }

        public Word(string _title, int _length, string _lang)
        {
            Title = _title;
            Length = _length;
            Lang = _lang;
        }
    }
}
