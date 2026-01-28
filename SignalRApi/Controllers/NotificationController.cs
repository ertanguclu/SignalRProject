using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.AboutDto;
using SignalR.DtoLayer.NotificationDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly INotificationService _notificationService;
        private readonly IMapper _mapper;

        public NotificationController(INotificationService notificationService, IMapper mapper)
        {
            _notificationService = notificationService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult NotificationList()
        {
            var values = _notificationService.TGetListAll();
            return Ok(values);
        }
        [HttpGet("NotificationCountByStatusFalse")]
        public IActionResult NotificationCountByStatusFalse()
        {
            var values = _notificationService.TNotificationCountByStatusFalse();
            return Ok(values);
        }
        [HttpGet("GetAllNotificationByFalse")]
        public IActionResult GetAllNotificationByFalse()
        {
            var values = _notificationService.TGetAllNotificationByFalse();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateNotification(CreateNotificationDto createNotificationDto)
        {
            createNotificationDto.Status = false;
            createNotificationDto.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            var value = _mapper.Map<Notification>(createNotificationDto);
            _notificationService.TAdd(value);
            return Ok("Ekleme işlemi başarıyla yapıldı");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteNotification(int id)
        {
            var values = _notificationService.TGetById(id);
            _notificationService.TDelete(values);
            return Ok("Bildirim silindi.");
        }
        [HttpGet("{id}")]
        public IActionResult GetNotification(int id)
        {
            var value = _notificationService.TGetById(id);
            var notification = _mapper.Map<ResultNotificationDto>(value);
            return Ok(notification);
        }
        [HttpPut]
        public IActionResult UpdateNotification(UpdateNotificationDto updateNotificationDto)
        {
            var value = _mapper.Map<Notification>(updateNotificationDto);
            _notificationService.TUpdate(value);
            return Ok("Bildirim güncellendi.");
        }
    }
}
