using Core.EntityFramework.Repository;
using DataAccess.EntityFramework.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Core.Utilities.Results.Abstract;
using DataAccess.EntityFramework.Context;
using Entities.DTOs;

namespace DataAccess.EntityFramework.Concrete
{
    public class CategoryDal : BaseEntityRepository<Category, BlogContext>, ICategoryDal
    {

    }
}
