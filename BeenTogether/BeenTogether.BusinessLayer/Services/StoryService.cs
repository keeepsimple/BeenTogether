using BeenTogether.BusinessLayer.BaseServices;
using BeenTogether.BusinessLayer.IServices;
using BeenTogether.Data.Infrastructure;
using BeenTogether.Models;

namespace BeenTogether.BusinessLayer.Services
{
    public class StoryService : BaseServices<Story>, IStoryService
    {
        public StoryService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
