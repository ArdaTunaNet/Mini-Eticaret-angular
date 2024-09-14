using EticaretServer.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EticaretServer.Domain.Entities
{
    public class Customer:BaseEntity
    {
        public string Name;
       public ICollection <Order> Orders { get; set; }
    }
}
