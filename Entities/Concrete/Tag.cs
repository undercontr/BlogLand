using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.CommonTypes.Entities;

namespace Entities.Concrete
{
    public class Tag : BaseEntity, IEntity
    {
        public string Name { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}
