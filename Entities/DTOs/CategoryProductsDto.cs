using System.Collections;
using System.Collections.Generic;
using Entities.Concrete;

namespace Entities.DTOs
{
    public class CategoryPostsDto
    {
        public Category Category { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
}