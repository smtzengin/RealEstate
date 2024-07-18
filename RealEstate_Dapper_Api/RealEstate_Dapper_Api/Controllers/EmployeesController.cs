using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Dtos.EmployeeDtos;
using RealEstate_Dapper_Api.Repositories.EmployeeRepositories;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeesController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet]
        public async Task<IActionResult> EmployeeList()
        {
            var values = await _employeeRepository.GetAllEmployees();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateEmployee(CreateEmployeeDto createEmployeeDto)
        {
            _employeeRepository.CreateEmployee(createEmployeeDto);
            return Ok("Employee Başarılı bir şekilde eklendi");
        }

        [HttpDelete("{employeeID}")]
        public IActionResult DeleteEmployee(int employeeID)
        {
            _employeeRepository.DeleteEmployee(employeeID);
            return Ok("Employee başarılı bir şekilde silindi!");
        }

        [HttpPut]
        public IActionResult UpdateEmployee(UpdateEmployeeDto updateEmployeeDto)
        {
            _employeeRepository.UpdateEmployee(updateEmployeeDto);
            return Ok("Employee Başarılı bir şekilde güncellendi!");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployeeByID(int id)
        {
            var value = await _employeeRepository.GetEmployee(id);
            return Ok(value);
        }
    }
}
