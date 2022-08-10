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
        [HttpGet("/api/BookItemsDto")]
        public List<BookItemDto> GetAllBookItemsDto()
        {
             var bookItemsList = bookItemServices.GetBookItemsList().ToList();
               return _mapper.Map<List<BookItemDto>>(bookItemsList);
        }

        // GET api/<BookItemApiController>/5
        [HttpGet("/api/BookItemDto/{id}")]
        public BookItemDto GetBookItemByIdDto(int id)
        {
            var bookItem = bookItemServices.GetBookItemById(id);
            return _mapper.Map<BookItemDto>(bookItem);
        }


        [HttpPost("/api/AddBookItem")]
        public string AddBookItem([FromBody] BookItem value)
        {
            bookItemServices.AddBookItem(value);
            return "done";  
        }


        [HttpPut("/api/editBookItem")]
        public BookItem EditBookItem([FromBody] BookItem bookItem)
        {
            bookItemServices.EditBookItemData(bookItem);
            return bookItem;
        }



        // DELETE api/<BookItemApiController>/5
        [HttpDelete("/api/deleteBookItem/{id}")]
        public void Delete(int id)
        {
            bookItemServices.DeleteBookItem(id);
        }
    }
}
