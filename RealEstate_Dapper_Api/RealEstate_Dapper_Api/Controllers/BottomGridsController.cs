using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Dtos.BottomGridDtos;

using RealEstate_Dapper_Api.Repositories.ButtomGridRepositories;


namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BottomGridsController : ControllerBase
    {
        private readonly IBottomGridRepository _bottomGridRepository;

        public BottomGridsController(IBottomGridRepository bottomGridRepository)
        {
            _bottomGridRepository = bottomGridRepository;
        }

        [HttpGet]
        public async Task<IActionResult> BottomGridList()
        {
            var values = await _bottomGridRepository.GetAllBottomGridsAsnyc();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBottomGrid(CreateBottomGridDto createBottomGridDto)
        {
            _bottomGridRepository.CreateBottomGrid(createBottomGridDto);
            return Ok("BottomGrid Başarılı bir şekilde eklendi");
        }

        [HttpDelete("{bottomGridID}")]
        public async Task<IActionResult> DeleteBottomGrid(int bottomGridID)
        {
            _bottomGridRepository.DeleteBottomGrid(bottomGridID);
            return Ok("BottomGrid başarılı bir şekilde silindi!");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBottomGrid(UpdateBottomGridDto updateBottomGridDto)
        {
            _bottomGridRepository.UpdateBottomGrid(updateBottomGridDto);
            return Ok("BottomGrid Başarılı bir şekilde güncellendi!");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBottomGridByID(int id)
        {
            var value = await _bottomGridRepository.GetBottomGrid(id);
            return Ok(value);
        }
    }
}
