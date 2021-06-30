using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.CommonTypes.Entities;

namespace Entities.Concrete
{
    public class Comment : BaseEntity, IEntity
    {
        public string Content { get; set; }
        public virtual AppUser User { get; set; }
        public virtual Post Post { get; set; }

    }
}
