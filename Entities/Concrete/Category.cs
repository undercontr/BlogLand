using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.CommonTypes.Entities;

namespace Entities.Concrete
{
    public class Category : BaseEntity, IEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}
