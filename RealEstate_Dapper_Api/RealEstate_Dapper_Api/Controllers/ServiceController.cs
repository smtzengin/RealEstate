using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Dtos.ServiceDtos;
using RealEstate_Dapper_Api.Repositories.ServiceRepository;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        private readonly IServiceRepository _serviceRepository;

        public ServiceController(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }
        [HttpPost]
        public async Task<IActionResult> CreateService(CreateServiceDto createServiceDto)
        {
            _serviceRepository.CreateService(createServiceDto);
            return Ok("Service Başarılı bir şekilde eklendi");
        }
        [HttpGet]
        public async Task<IActionResult> ServiceList()
        {
            var values = await _serviceRepository.GetAllServiceAsync();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetServiceByID(int id)
        {
            var value = await _serviceRepository.GetService(id);
            return Ok(value);
        }

        [HttpDelete("{serviceID}")]
        public async Task<IActionResult> DeleteService(int serviceID)
        {
            _serviceRepository.DeleteService(serviceID);
            return Ok("Service başarılı bir şekilde silindi!");
        }

        [HttpPut]
        public IActionResult UpdateCategory(UpdateServiceDto updateServiceDto)
        {
            _serviceRepository.UpdateService(updateServiceDto);
            return Ok("Kategori Başarılı bir şekilde güncellendi!");
        }

    }
}
