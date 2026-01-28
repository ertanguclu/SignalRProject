using AutoMapper;
using SignalR.DtoLayer.NotificationDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Mapping
{
    public class NotificationMapping : Profile
    {
        public NotificationMapping()
        {
            CreateMap<CreateNotificationDto, Notification>().ReverseMap();
            CreateMap<Notification, ResultNotificationDto>().ReverseMap();
            CreateMap<Notification, UpdateNotificationDto>().ReverseMap();
        }
    }
}
