using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.CommonTypes.Entities;

namespace Entities.Concrete
{
    public class Post : BaseEntity, IEntity
    {
        public string Title { get; set; }
        public string MetaTitle { get; set; }
        public string Content { get; set; }
        public string Summary { get; set; }
        public string UrlSlug { get; set; }
        public bool IsPublic { get; set; }
        public bool IsHomePage { get; set; }
        public int UserId { get; set; }
        public virtual AppUser User { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
