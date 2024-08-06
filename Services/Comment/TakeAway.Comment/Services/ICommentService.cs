using TakeAway.Comment.Dtos;

namespace TakeAway.Comment.Services
{
    public interface ICommentService
    {
        Task<List<ResultUserCommentDto>> GetAllUserCommentAsync();
        Task CreateUserCommandAsync(CreateUserCommentDto createUserCommentDto);
        Task UpdateUserCommandAsync(UpdateUserCommentDto updateUserCommentDto);
        Task DeleteUserCommandAsync(int id);
        Task<GetByIdUserCommentDto> GetByIdUserCommentAsync(int id);
        Task<List<GetByProductIdUserCommentDto>> GetByProductIdUserCommentAsync(string id);
    }
}
