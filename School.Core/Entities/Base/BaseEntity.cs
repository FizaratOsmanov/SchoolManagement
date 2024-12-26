using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Core.Entities.Base
{
    public class BaseEntity
    {
        public int İd { get; set; }

        public bool IsDeleted { get; set; }
    }
}
