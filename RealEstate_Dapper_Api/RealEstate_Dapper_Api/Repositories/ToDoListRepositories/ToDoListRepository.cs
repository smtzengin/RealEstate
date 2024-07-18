﻿using Dapper;
using RealEstate_Dapper_Api.Dtos.ToDoListDtos;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.ToDoListRepositories
{
    public class ToDoListRepository : IToDoListRepository
    {
        private readonly Context _context;
        public ToDoListRepository(Context context)
        {
            _context = context;
        }
        public async Task CreateToDoList(CreateToDoListDto ToDoListDto)
        {
            string query = "insert into ToDoList (Description, ToDoListStatus) values (@description, @ToDoListStatus)";
            var parameters = new DynamicParameters();
            parameters.Add("@description", ToDoListDto.Description);
            parameters.Add("toDoListStatus", true);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task DeleteToDoList(int id)
        {
            string query = "Delete from ToDoList Where ToDoListID=@toDoListID";
            var parameteres = new DynamicParameters();
            parameteres.Add("@toDoListID", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameteres);
            }
        }

        public async Task<List<ResultToDoListDto>> GetAllToDoList()
        {
            string query = "select * from ToDoList";
            using(var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultToDoListDto>(query);
                return values.ToList();
            }

        }

        public async Task<GetByIDToDoListDto> GetToDoList(int id)
        {
            string query = "select * from ToDoList where ToDoListID=@toDoListID";
            var parameters = new DynamicParameters();
            parameters.Add("@toDoListID", id);
            using(var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIDToDoListDto>(query,parameters);
                return values;
            }
        }

        public Task UpdateToDoList(UpdateToDoListDto ToDoListDto)
        {
            throw new NotImplementedException();
        }
    }
}
