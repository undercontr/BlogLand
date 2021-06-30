using Business.Abstract;
using Core.CommonTypes.Business;
using Core.CommonTypes.Entities;
using Core.EntityFramework.Repository;
using DataAccess.EntityFramework.Abstract;
using DataAccess.EntityFramework.Concrete;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CommentManager : BaseServiceRepository<Comment>, ICommentService
    {
        public CommentManager(ICommentDal dataAccessType) : base(dataAccessType)
        {
        }
    }
}