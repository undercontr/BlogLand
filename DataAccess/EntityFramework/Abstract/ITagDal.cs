using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.EntityFramework.Repository;
using Entities.Concrete;

namespace DataAccess.EntityFramework.Abstract
{
    public interface ITagDal : IEntityRepository<Tag>
    {
        
    }
}
