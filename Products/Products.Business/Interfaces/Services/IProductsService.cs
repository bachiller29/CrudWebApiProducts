using Products.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Business.Interfaces.Services
{
    public interface IProductsService
    {
        Product CreateProducs(Product product);
        void UpdateState(Product product);
        Task<IEnumerable<Product>> GetAllProducts();
        Product GetProductsById(int id);
        Task<Product> Delete(int IdProduct);
    }
}
