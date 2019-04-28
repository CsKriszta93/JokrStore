using BLL.DTO;
using System.Threading.Tasks;

namespace BLL.ServiceInterfaces
{
    public interface ICommentService
    {
        Task AddComment(CommentDto commentDto);
    }
}
