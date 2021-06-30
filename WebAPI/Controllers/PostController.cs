using Core.CommonTypes.API;
using Core.CommonTypes.Business;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;

namespace WebAPI.Controllers
{
    public class PostController : BaseApiController<Post>
    {
        public PostController(IPostService businessLayer) : base(businessLayer)
        {
        }
    }
}
