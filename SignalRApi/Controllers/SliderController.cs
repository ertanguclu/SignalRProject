using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.FeatureDto;
using SignalR.DtoLayer.SliderDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SliderController : ControllerBase
    {
        private readonly ISliderService _sliderService;
        private readonly IMapper _mapper;

        public SliderController(IMapper mapper, ISliderService sliderService)
        {
            _mapper = mapper;
            _sliderService = sliderService;
        }
        [HttpGet]
        public IActionResult SliderList()
        {
            var values = _mapper.Map<List<ResultSliderDto>>(_sliderService.TGetListAll());
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateSlider(CreateSliderDto createSliderDto)
        {
            var value = _mapper.Map<Slider>(createSliderDto);
            _sliderService.TAdd(value);
            return Ok("Öne Çıkan Bilgisi Eklendi.");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteSlider(int id)
        {
            var values = _sliderService.TGetById(id);
            _sliderService.TDelete(values);
            return Ok("Öne Çıkan Bilgisi Silindi.");
        }
        [HttpPut]
        public IActionResult UpdateSlider(UpdateSliderDto updateSliderDto)
        {
            var value = _mapper.Map<Slider>(updateSliderDto);
            _sliderService.TUpdate(value);
            return Ok("Öne Çıkan Alan Bilgisi Güncellendi.");
        }
        [HttpGet("{id}")]
        public IActionResult GetSlider(int id)
        {
            var value = _mapper.Map<GetSliderDto>(_sliderService.TGetById(id));
            return Ok(value);
        }
    }
}
