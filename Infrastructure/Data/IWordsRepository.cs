using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lingowords.Domain;

namespace lingowords.Repositories
{
    public interface IWordsRepository
    {
        IList<Word> ReadWords();
    }
}