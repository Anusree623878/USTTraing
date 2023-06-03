using ProductMicroService.Models;
using System.Collections.Generic;

namespace ProductMicroService.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();

        Product GetProductById(int ProductId);

        void InsertProduct(Product Product);

        void DeleteProduct(int  ProductId);

        void UpdateProduct(Product Product);

        void Save();
    }
}
