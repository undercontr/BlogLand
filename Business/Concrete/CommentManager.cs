using System.Collections.Generic;
using Business.Abstract;
using Core.CommonTypes.Business;
using Core.CommonTypes.Entities;
using Core.EntityFramework.Repository;
using Core.Utilities.Results;
using Core.Utilities.Results.Abstract;
using DataAccess.EntityFramework.Abstract;
using DataAccess.EntityFramework.Concrete;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CommentManager : ICommentService
    {
        private readonly ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public IResult Add(Comment comment)
        {
            _commentDal.Add(comment);
            return new SuccessResult();
        }

        public IResult Update(Comment comment)
        {
            _commentDal.Update(comment);
            return new SuccessResult();
        }

        public IResult Delete(Comment comment)
        {
            _commentDal.Delete(comment);
            return new SuccessResult();
        }

        public IDataResult<ICollection<Comment>> GetAll()
        {
            return new SuccessDataResult<ICollection<Comment>>(_commentDal.GetAll());
        }

        public IDataResult<Comment> GetById(int id)
        {
            return new SuccessDataResult<Comment>(_commentDal.Get(p => p.Id == id));
        }
    }
}