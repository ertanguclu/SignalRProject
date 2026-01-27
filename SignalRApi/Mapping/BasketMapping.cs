using AutoMapper;
using SignalR.EntityLayer.Entities;
using SignalRApi.Models;

namespace SignalRApi.Mapping
{
    public class BasketMapping : Profile
    {
        public BasketMapping()
        {
            CreateMap<Basket, ResultBaketListWithProducts>()
                .ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.Product.ProductName));
        }
    }
}
