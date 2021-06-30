using System.Collections.Generic;
using Business.Abstract;
using Core.CommonTypes.Business;
using Core.EntityFramework.Repository;
using Core.Utilities.Results.Abstract;
using DataAccess.EntityFramework.Abstract;
using DataAccess.EntityFramework.Concrete;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CategoryManager : BaseServiceRepository<Category>
    {
        public CategoryManager(ICategoryDal dataAccessType) : base(dataAccessType)
        {
        }
    }
}