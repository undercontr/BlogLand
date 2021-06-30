using Business.Abstract;
using Core.CommonTypes.Business;
using Core.EntityFramework.Repository;
using DataAccess.EntityFramework.Concrete;
using Entities.Concrete;

namespace Business.Concrete
{
    public class TagManager : BaseServiceRepository<Tag>, ITagService, IBusiness

    {
        public TagManager(IEntityRepository<Tag> dataAccessType) : base(dataAccessType)
        {
        }
    }
}