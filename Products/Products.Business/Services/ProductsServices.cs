using Products.Business.Interfaces.Repositories;
using Products.Business.Interfaces.Services;
using Products.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Business.Services
{
    public  class ProductsServices : IProductsService
    {
        private readonly IProductsRepository _repo;

        public ProductsServices(IProductsRepository repository)
        {
            _repo = repository;
        }

        public Product CreateProducs(Product product)
        {
            return _repo.CreateProducs(product);
        }


        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            return await _repo.GetAllProducts();
        }


        public Product GetProductsById(int id)
        {
            return _repo.GetProductsById(id);
        }

        public void UpdateState(Product product)
        {
            _repo.UpdateState(product);
        }

        public async Task<Product> Delete(int IdProduct)
        {
            return await _repo.Delete(IdProduct);
        }
    }
}
