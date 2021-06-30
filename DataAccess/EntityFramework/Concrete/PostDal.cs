using Core.EntityFramework.Repository;
using DataAccess.EntityFramework.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.CommonTypes.Entities;
using DataAccess.EntityFramework.Context;

namespace DataAccess.EntityFramework.Concrete
{
    public class PostDal : BaseEntityRepository<Post, BlogContext>, IPostDal
    {
    }
}
