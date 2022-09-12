using BeenTogether.BusinessLayer.BaseServices;
using BeenTogether.BusinessLayer.IServices;
using BeenTogether.Data.Infrastructure;
using BeenTogether.Models;

namespace BeenTogether.BusinessLayer.Services
{
    public class LoveService : BaseServices<Love>, ILoveService
    {
        public LoveService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
