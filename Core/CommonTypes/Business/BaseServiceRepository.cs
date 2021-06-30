using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.Aspects.Autofac.Validation;
using Core.CommonTypes.Entities;
using Core.EntityFramework.Repository;
using Core.Utilities.Results;
using Core.Utilities.Results.Abstract;
using FluentValidation;

namespace Core.CommonTypes.Business
{
    public abstract class BaseServiceRepository<TEntity> : IBaseServiceRepository<TEntity>
        where TEntity : BaseEntity, IEntity, new()
    {
        private readonly IEntityRepository<TEntity> _dataAccessType;

        public BaseServiceRepository(IEntityRepository<TEntity> dataAccessType)
        {
            _dataAccessType = dataAccessType;
        }
        
        public IResult Add(TEntity entity)
        {
            _dataAccessType.Add(entity);
            return new SuccessResult();
        }

        public IResult Update(TEntity entity)
        {
            _dataAccessType.Update(entity);

            return new SuccessResult();
        }

        public IResult Delete(TEntity entity)
        {
            _dataAccessType.Delete(entity);

            return new SuccessResult();
        }

        public IDataResult<ICollection<TEntity>> GetAll()
        {
            return new SuccessDataResult<ICollection<TEntity>>(_dataAccessType.GetAll());
        }

        public IDataResult<TEntity> GetById(int id)
        {
            return new SuccessDataResult<TEntity>(_dataAccessType.Get(e => e.Id == id));
        }
    }
}