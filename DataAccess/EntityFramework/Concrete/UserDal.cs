using Core.EntityFramework.Repository;
using DataAccess.EntityFramework.Abstract;
using DataAccess.EntityFramework.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework.Concrete
{
    public class UserDal : BaseEntityRepository<AppUser, BlogContext>, IUserDal
    {
    }
}
