using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lingowords.Domain;
using lingowords.Repositories;
using lingowords.Services;

namespace lingowords.Controller
{

    [ApiController]
    [Route("Words")]
    public class WordsController : ControllerBase
    {
        readonly IWordsService wordService;

        public WordsController(IWordsService _wordService)
        {
            wordService = _wordService;
        }

        [HttpGet]
        public IList<Word> Get()
        {
            return wordService.CheckWords();
        }
    }
}
