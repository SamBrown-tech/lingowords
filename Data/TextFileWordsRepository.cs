using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lingowords.Domain;

namespace lingowords.Data
{
    public interface WordsRepository
    {
        IList<Word> ReadWords();
    }
}
