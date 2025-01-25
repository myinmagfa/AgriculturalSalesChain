using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgriculturalSalesChain.Domain.Common
{
    public abstract class BaseDomainEntitiy
    {
        public int Id { get; set; }
        public DateTime CreationDateTime { get; set; }
        public int CreateUserId { get; set; }
        public DateTime? LastUpdateDateTime { get; set; }
        public int? LastUpdateUserId { get; set; }
    }
}
