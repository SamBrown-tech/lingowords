using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using lingowords.Domain;

namespace lingowords.Repositories
{
    public class TextFileWordsRepository : IWordsRepository
    {
        public IList<Word> ReadWords()
        {
            IList<Word> words = new List<Word>();
            try
            {
                // Read file 
                string[] content = File.ReadAllLines("dutch-words.txt");
                foreach (var word in from _word in content
                                     let word = new Word(_word)
                                     select word)
                {
                    words.Add(word);
                }
            }
            catch (IOException e)
            {
                Debug.WriteLine("Error: {0}", e.Message);
            }


            return words;
        }
    }
}
