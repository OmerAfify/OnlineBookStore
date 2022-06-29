using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OnlineBookStore.DTOs;
using OnlineBookStore.Interfaces;

namespace OnlineBookStore.APIs
{


    [Route("api/[controller]")]
    [ApiController]
    public class BookCategoryApiController : ControllerBase
    {



        private IBookCategoryServices bookCategoryServices;
        private IMapper _mapper;
        public BookCategoryApiController(IBookCategoryServices bookCategoryServices, IMapper mapper)
        {
            this.bookCategoryServices = bookCategoryServices;
            _mapper = mapper;
        }


        // GET: api/<BookCategoryApiController>
        [HttpGet("/api/BookCategories")]
        public List<BookCategoryDto> GetBookCategoriesApi()
        {
            var bookcategoriesList = bookCategoryServices.GetBookCategoriesList().ToList();
            return _mapper.Map<List<BookCategoryDto>>(bookcategoriesList);
        }




        // GET api/<BookCategoryApiController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BookCategoryApiController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BookCategoryApiController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BookCategoryApiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
