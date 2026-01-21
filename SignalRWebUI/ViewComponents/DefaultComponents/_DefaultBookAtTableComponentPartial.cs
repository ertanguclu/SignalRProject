using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalRWebUI.Dtos.AboutDtos;
using SignalRWebUI.Dtos.BookingDtos;

namespace SignalRWebUI.ViewComponents.DefaultComponents
{
    public class _DefaultBookAtTableComponentPartial :ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultBookAtTableComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7161/api/Booking");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultBookingDto>>(jsonData);
            return View(values);
        }
    }
}
