using BeenTogether.BusinessLayer.BaseServices;
using BeenTogether.BusinessLayer.IServices;
using BeenTogether.Data.Infrastructure;
using BeenTogether.Models;

namespace BeenTogether.BusinessLayer.Services
{
    public class CommentService : BaseServices<Comment>, ICommentService
    {
        public CommentService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
