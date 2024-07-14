
using RealEstate_Dapper_Api.Dtos.PopularLocationDtos;


namespace RealEstate_Dapper_Api.Repositories.PopularLocationRepositories
{
	public interface IPopularLocationRepository
	{
		Task<List<ResultPopularLocationDto>> GetAllPopularLocationAsync();
        Task CreatePopularLocation(CreatePopularLocationDto createPopularLocationDto);
        Task DeletePopularLocation(int popularLocationID);
        Task UpdatePopularLocation(UpdatePopularLocationDto updatePopularLocationDto);
        Task<GetByIDPopularLocation> GetPopularLocation(int popularLocationID);
    }
}
