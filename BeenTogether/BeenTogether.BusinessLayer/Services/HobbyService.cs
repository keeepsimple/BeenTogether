using BeenTogether.BusinessLayer.BaseServices;
using BeenTogether.BusinessLayer.IServices;
using BeenTogether.Data.Infrastructure;
using BeenTogether.Models;

namespace BeenTogether.BusinessLayer.Services
{
    public class HobbyService : BaseServices<Hobby>, IHobbyService
    {
        public HobbyService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
