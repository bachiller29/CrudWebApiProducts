using Microsoft.EntityFrameworkCore;
using Products.Business.Interfaces.Repositories;
using Products.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Data.Repositories
{
    public class ProductsRepository : IProductsRepository

    {
        private readonly ProductsContext _context;

        public ProductsRepository(ProductsContext context)
        {
            _context = context;
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        #region Api products
        public Product CreateProducs(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }

        public void UpdateState(Product product)
        {
            _context.Update(product);
            _context.SaveChanges();
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await _context.Products.ToListAsync();
        }

        public Product GetProductsById(int id)
        {
            return _context.Products.Find(id);
        }

        public async Task<Product> Delete(int IdProduct)
        {
            var product = await _context.Products.FindAsync(IdProduct);
            if (product == null)
            {
                return null;
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return product;
        }

#endregion
    }
}
