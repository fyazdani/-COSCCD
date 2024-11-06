using System;
using ECommerseAPI.Models;

namespace ECommerseAPI.Services;

// Product Service Implementation (In-Memory Example)
public class ProductService : IProductService
{
    private readonly List<Product> _products = new List<Product>();

    public IEnumerable<Product> GetAllProducts() => _products;

    public Product GetProductById(Guid id) => _products.Find(p => p.Id == id);

    public Product CreateProduct(Product product)
    {
        product.Id = Guid.NewGuid();
        _products.Add(product);
        return product;
    }

    public void UpdateProduct(Guid id, Product updatedProduct)
    {
        var index = _products.FindIndex(p => p.Id == id);
        if (index != -1)
        {
            updatedProduct.Id = id;  // Preserve original ID
            _products[index] = updatedProduct;
        }
    }

    public void DeleteProduct(Guid id) => _products.RemoveAll(p => p.Id == id);
}
