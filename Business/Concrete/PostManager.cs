using Business.Abstract;
using Core.CommonTypes.Business;
using Core.EntityFramework.Repository;
using DataAccess.EntityFramework.Abstract;
using DataAccess.EntityFramework.Concrete;
using Entities.Concrete;

namespace Business.Concrete
{
    public class PostManager : BaseServiceRepository<Post>, IPostService
    {

        public PostManager(IPostDal dataAccessType) : base(dataAccessType)
        {
        }
    }
}