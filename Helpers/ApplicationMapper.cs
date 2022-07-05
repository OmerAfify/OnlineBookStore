using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using OnlineBookStore.DTOs;
using OnlineBookStore.Models;

namespace OnlineBookStore.Helpers
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<BookItem, BookItemDto>().ForMember(dest => dest.bookCategoryName, opt => opt.MapFrom(src => src.bookCategory.bookCategoryName)).ReverseMap();
           
            CreateMap<BookCategory, BookCategoryDto>().ReverseMap();
 
        }
    }
}
