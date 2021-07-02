using Core.CommonTypes.Business;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IPostService
    {
        IResult Add(Post entity);
        IResult Update(Post entity);
        IResult Delete(Post entity);
        IDataResult<ICollection<Post>> GetAll();
        IDataResult<Post> GetById(int id);
    }
}