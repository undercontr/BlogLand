using System.Collections.Generic;
using Business.Abstract;
using Core.CommonTypes.Business;
using Core.EntityFramework.Repository;
using Core.Utilities.Results;
using Core.Utilities.Results.Abstract;
using DataAccess.EntityFramework.Abstract;
using DataAccess.EntityFramework.Concrete;
using Entities.Concrete;

namespace Business.Concrete
{
    public class PostManager : IPostService
    {
        private readonly IPostDal _postDal;

        public PostManager(IPostDal postDal)
        {
            _postDal = postDal;
        }

        public IResult Add(Post entity)
        {
            _postDal.Add(entity);
            return new SuccessResult();
        }

        public IResult Update(Post entity)
        {
            _postDal.Update(entity);
            return new SuccessResult();
        }

        public IResult Delete(Post entity)
        {
            _postDal.Delete(entity);
            return new SuccessResult();
        }

        public IDataResult<ICollection<Post>> GetAll()
        {
            return new SuccessDataResult<ICollection<Post>>(_postDal.GetAll());
        }

        public IDataResult<Post> GetById(int id)
        {
            return new SuccessDataResult<Post>(_postDal.Get(p => p.Id == id));
        }
    }
}