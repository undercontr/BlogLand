using Core.CommonTypes.API;
using Entities.Concrete;
using Business.Concrete;
using Core.CommonTypes.Business;

namespace API.Controllers
{
    public class PostController : BaseApiController<Post>
    {
        public PostController(IBaseServiceRepository<Post> businessLayer) : base(businessLayer)
        {
        }
    }
}
