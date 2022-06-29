using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OnlineBookStore.DTOs;
using OnlineBookStore.Interfaces;
using OnlineBookStore.Models;

namespace OnlineBookStore.APIs
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookItemApiController : ControllerBase
    {

        private IBookItemServices bookItemServices;
        private IMapper _mapper;
        public BookItemApiController(IBookItemServices bookItemServices, IMapper mapper)
        {
            this.bookItemServices = bookItemServices;
            _mapper = mapper;
        }

        // GET: api/<BookItemApiController>
        [HttpGet("/api/BookItems")]
        public List<BookItemDto> Get()
        {
             var bookItemsList = bookItemServices.GetBookItemsList().ToList();
               return _mapper.Map<List<BookItemDto>>(bookItemsList);
        }

        // GET api/<BookItemApiController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BookItemApiController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BookItemApiController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BookItemApiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
