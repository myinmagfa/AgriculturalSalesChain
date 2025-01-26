using AgriculturalSalesChain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgriculturalSalesChain.Application.Persistence.Contracts
{
    public interface IInventoryRepository:IGenericRepository<Inventory>
    {
    }
}
