﻿using RealEstate_Dapper_Api.Dtos.ContactDtos;

namespace RealEstate_Dapper_Api.Repositories.ContactRepositories
{
    public interface IContactRepository
    {
        Task<List<ResultContactDto>> GetAllContactAsync();
        Task<List<Last4ContactResultDto>> GetLast4Contact();
        Task CreateContact(CreateContactDto employeeDto);
        Task DeleteContact(int id);
        Task<GetByIDContactDto> GetContact(int id);
    }
}
