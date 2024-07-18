using RealEstate_Dapper_Api.Dtos.EmployeeDtos;

namespace RealEstate_Dapper_Api.Repositories.EmployeeRepositories
{
    public interface IEmployeeRepository
    {
        Task<List<ResultEmployeeDto>> GetAllEmployees();
        Task CreateEmployee(CreateEmployeeDto employeeDto);
        Task DeleteEmployee(int id);
        Task UpdateEmployee(UpdateEmployeeDto employeeDto);
        Task<GetByIDEmployeeDto> GetEmployee(int id);
    }
}
