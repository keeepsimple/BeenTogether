using BeenTogether.BusinessLayer.BaseServices;
using BeenTogether.BusinessLayer.IServices;
using BeenTogether.Data.Infrastructure;
using BeenTogether.Models;

namespace BeenTogether.BusinessLayer.Services
{
    public class ImageMemoryService : BaseServices<ImageMemory>, IImageMemoryService
    {
        public ImageMemoryService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
