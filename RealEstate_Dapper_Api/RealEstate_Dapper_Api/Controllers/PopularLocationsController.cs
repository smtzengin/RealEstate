using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Dtos.PopularLocationDtos;
using RealEstate_Dapper_Api.Dtos.ServiceDtos;
using RealEstate_Dapper_Api.Repositories.PopularLocationRepositories;

namespace RealEstate_Dapper_Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PopularLocationsController : ControllerBase
	{
		private readonly IPopularLocationRepository _popularLocationRepository;

		public PopularLocationsController(IPopularLocationRepository popularLocationRepository)
		{
			_popularLocationRepository = popularLocationRepository;
		}

        [HttpPost]
        public IActionResult CreatePopularLocation(CreatePopularLocationDto createPopularLocation)
        {
            _popularLocationRepository.CreatePopularLocation(createPopularLocation);
            return Ok("Service Başarılı bir şekilde eklendi");
        }
        [HttpGet]
        public async Task<IActionResult> PopularLocationList()
        {
            var values = await _popularLocationRepository.GetAllPopularLocationAsync();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPopularLocationByID(int id)
        {
            var value = await _popularLocationRepository.GetPopularLocation(id);
            return Ok(value);
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePopularLocation(int popularLocationID)
        {
            _popularLocationRepository.DeletePopularLocation(popularLocationID);
            return Ok("Location başarılı bir şekilde silindi!");
        }

        [HttpPut]
        public IActionResult UpdatePopularLocation(UpdatePopularLocationDto updatePopularLocationID)
        {
            _popularLocationRepository.UpdatePopularLocation(updatePopularLocationID);
            return Ok("Location Başarılı bir şekilde güncellendi!");
        }

    }
}
