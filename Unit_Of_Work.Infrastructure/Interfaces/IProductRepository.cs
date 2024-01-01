using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit_Of_Work.Core;

namespace Unit_Of_Work.Infrastructure.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetaAll();
        Task<Product> GetaById(int id);

        Task Add(Product model);

        Task Update(Product model);

        Task Delete(int id);

    }
}
