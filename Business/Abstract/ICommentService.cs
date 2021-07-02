using System.Collections.Generic;
using Core.CommonTypes.Business;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICommentService : IBaseServiceRepository<Comment>
    {
        
    }
}