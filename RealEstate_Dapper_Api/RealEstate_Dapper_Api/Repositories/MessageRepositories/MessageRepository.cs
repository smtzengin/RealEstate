using Dapper;
using RealEstate_Dapper_Api.Dtos.MessageDtos;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.MessageRepositories
{
    public class MessageRepository : IMessageRepository
    {
        private readonly Context _context;

        public MessageRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<ResultInboxMessageDto>> GetInBoxLast3MessageListByReceiver(int id)
        {
            string query = "Select Top(3) MessageID,Name,Subject,Detail,SendDate,IsRead,UserImageUrl from Message Inner join AppUser On Message.Sender = AppUser.UserID where Receiver=1 order by MessageID Desc";
            var parameters = new DynamicParameters();
            parameters.Add("@receiverId", id);
            using(var connection = _context.CreateConnection()) { 
                var values = await connection.QueryAsync<ResultInboxMessageDto>(query, parameters);
                return values.ToList();

            }
        }
    }
}
