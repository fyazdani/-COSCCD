using System;

namespace ECommerseAPI.Models;

    // Interface for Product Service
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(Guid id);
        Product CreateProduct(Product product);
        void UpdateProduct(Guid id, Product updatedProduct);
        void DeleteProduct(Guid id);
    }