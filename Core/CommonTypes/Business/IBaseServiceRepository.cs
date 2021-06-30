using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.CommonTypes.Entities;
using Core.Utilities.Results.Abstract;

namespace Core.CommonTypes.Business
{
    public interface IBaseServiceRepository<TEntity>
        where TEntity : BaseEntity, new()
    {
        IResult Add(TEntity entity);
        IResult Update(TEntity entity);
        IResult Delete(TEntity entity);
        IDataResult<ICollection<TEntity>> GetAll();
        IDataResult<TEntity> GetById(int id);

    }
}