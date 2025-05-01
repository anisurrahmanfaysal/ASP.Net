using AutoMapper;
using Note.Domain.Entities;
using Note.Web.Areas.Admin.Models;

namespace Note.Web
{
    public class WebProfile : Profile
    {
        public WebProfile()
        {
            CreateMap<AddAuthorModel, Author>().ReverseMap();
        }
    }
}
