﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trainer.BL.Services;

namespace Trainer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly SearchService _searchService;

        public SearchController(SearchService searchService)
        {
            _searchService = searchService;
        }

        [HttpGet("getWordsByName")]
        public async Task<IActionResult> GetWordsByName(string term)
        {
            return Ok(await _searchService.GetWordsByNameAsync(term));
        }
    }
}
