using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        [HttpGet("TotalOrderCount")]
        public IActionResult TotalOrderCount()
        {
            var value = _orderService.TTotalOrderCount();
            return Ok(value);
        }
        [HttpGet("ActiveOrderCount")]
        public IActionResult ActiveOrderCount()
        {
            var value = _orderService.TActiveOrderCount();
            return Ok(value);
        }
        [HttpGet("LastOrderPrice")]
        public IActionResult LastOrderPrice()
        {
            var value = _orderService.TLastOrderPrice();
            return Ok(value);
        }
        [HttpGet("TodayTotalPrice")]
        public IActionResult TodayTotalPrice()
        {
            var value = _orderService.TTodayTotalPrice();
            return Ok(value);
        }
    }
}
