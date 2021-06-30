using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.EntityFramework.Repository;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore.Storage;

namespace DataAccess.EntityFramework.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
        
    }
}
