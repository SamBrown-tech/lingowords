using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lingowords.Domain;
using lingowords.Repositories;
using System.Text.RegularExpressions;

namespace lingowords.Services
{
    public class DutchWordsService : IWordsService
    {
        IWordsRepository textFileRepository;

        public DutchWordsService(IWordsRepository _textFileWordsRepository)
        {
            textFileRepository = _textFileWordsRepository;
        }

        public string CheckWord(string text)
        {
            Match match = Regex.Match(text, @"^[a-z]{5,7}$");

            return match.Value;
        }

        public IList<Word> CheckWords()
        {
            Language lang = Language.Dutch;
            IList<Word> words = new List<Word>();
            foreach (var word in from _word in textFileRepository.ReadWords()
                                 let validatedWord = CheckWord(_word.Title)
                                 where string.IsNullOrEmpty(validatedWord) == false
                                 let word = new Word(validatedWord, validatedWord.Length, lang.ToString())
                                 select word)
            {
                words.Add(word);
            }

            return words;
        }


        //IList<Word> WordsService.CheckWords()
        //{
        //    Language language = Language.Dutch;
        //    IList<Word> words = new List<Word>();
        //    foreach (var word in from _word in textFileRepository.ReadWords()
        //                         let validatedWord = CheckWord(_word.Title)
        //                         where !string.IsNullOrEmpty(validatedWord)
        //                         let word = new Word(validatedWord, validatedWord.Length, language.ToString())
        //                         select word)
        //    {
        //        words.Add(word);
        //    }

        //    return words;
        //}
    }
}
