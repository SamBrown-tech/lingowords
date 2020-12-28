using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using lingowords.Domain;

namespace lingowords.Data
{
    public class TextFileWordsRepository : WordsRepository
    {
        public IList<Word> ReadWords()
        {
            IList<Word> wordsList = new List<Word>();
            try
            {
                // Read file 
                string[] content = File.ReadAllLines("dutch-words.txt");
                foreach(var _word in content)
                {
                    Word word = new Word(_word);
                    wordsList.Add(word);
                }
            } catch(IOException e) {
                Debug.WriteLine("Error: {0}", e.Message);
            }


            return wordsList;
        }
    }
}
