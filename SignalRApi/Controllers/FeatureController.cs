using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.FeatureDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeatureController : ControllerBase
    {
        private readonly IFeatureService _featureService;
        private readonly IMapper _mapper;

        public FeatureController(IMapper mapper, IFeatureService featureService)
        {
            _mapper = mapper;
            _featureService = featureService;
        }
        [HttpGet]
        public IActionResult FeatureList()
        {
            var values = _mapper.Map<List<ResultFeatureDto>>(_featureService.TGetListAll());
            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateFeature(CreateFeatureDto createFeatureDto)
        {
            var value = _mapper.Map<Feature>(createFeatureDto);
            _featureService.TAdd(value);
            return Ok("Öne Çıkan Bilgisi Eklendi.");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteFeature(int id)
        {
            var values = _featureService.TGetById(id);
            _featureService.TDelete(values);
            return Ok("Öne Çıkan Bilgisi Silindi.");
        }
        [HttpPut]
        public IActionResult UpdateFeature(UpdateFeatureDto updateFeatureDto)
        {
            var value = _mapper.Map<Feature>(updateFeatureDto);
            _featureService.TUpdate(value);
            return Ok("Öne Çıkan Alan Bilgisi Güncellendi.");
        }
        [HttpGet("{id}")]
        public IActionResult GetFeature(int id)
        {
            var value = _mapper.Map<GetFeatureDto>(_featureService.TGetById(id));
            return Ok(value);
        }
    }
}
