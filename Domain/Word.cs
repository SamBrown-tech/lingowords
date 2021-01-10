namespace lingowords.Domain
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class Word
    {
        public string Title { get; }
        public int Length { get; }
        public string Lang { get; }

        public Word(string title)
        {
            Title = title;
        }

        public Word(string title, int length, string lang)
        {
            Title = title;
            Length = length;
            Lang = lang;
        }
    }
}
