
using Kidsffw.Contracts.Interfaces;
using Kidsffw.Models;
using Microsoft.AspNetCore.Mvc;

namespace kidsffw.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly ILogger<CityController> _logger;
        private readonly ICityRepository _cityRepository;
        public CityController(ILogger<CityController> logger, ICityRepository cityRepository)
        {
            _logger = logger;
            _cityRepository = cityRepository;
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] City city)
        {
            if (city == null)
            {
                return BadRequest();
            }
            await _cityRepository.AddAsync(city);
            return Ok(city);
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var cities = _cityRepository.GetAllAsync();
            return Ok(cities);
        }
        [HttpGet("GetAllCities")]
        public async Task<IActionResult> GetAllCities()
        {
            var cities =  _cityRepository.GetAllCityNames();
            return Ok(cities);
        }
    }
}
