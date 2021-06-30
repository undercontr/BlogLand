using Business.Abstract;
using Core.CommonTypes.Business;
using Core.EntityFramework.Repository;
using DataAccess.EntityFramework.Concrete;
using Entities.Concrete;

namespace Business.Concrete
{
    public class UserManager : BaseServiceRepository<AppUser>, IUserService, IBusiness
    {
        public UserManager(IEntityRepository<AppUser> dataAccessType) : base(dataAccessType)
        {
        }
    }
}