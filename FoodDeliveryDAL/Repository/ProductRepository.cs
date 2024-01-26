using FoodDeliveryDAL.Data;
using FoodDeliveryDAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryDAL.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly FoodDbContext _context;

        public ProductRepository(FoodDbContext context)
        {
            _context = context;
        }

        // Create
        public Product CreateProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }

        // Read
        public Product GetProductById(int productId)
        {
            return _context.Products.Find(productId);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }

        // Update
        public Product UpdateProduct(Product product)
        {
            var existingProduct = _context.Products.Find(product.ProductId);

            if (existingProduct != null)
            {
                // Update the properties of the existing product with the values from the input product
                existingProduct.Name = product.Name;
                existingProduct.Description = product.Description;
                existingProduct.Price = product.Price;
                existingProduct.ImageFileName = product.ImageFileName;

                _context.SaveChanges();
            }

            return existingProduct;
        }

        // Delete
        public Product DeleteProduct(int productId)
        {
            var product = _context.Products.Find(productId);

            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }

            return product;
        }

        // Search
        public IEnumerable<Product> SearchProducts(string searchTerm)
        {
            // Implement the search logic based on the provided search term
            // For example, searching by product name containing the searchTerm
            return _context.Products
         .Where(p => p.Name.ToUpper().Contains(searchTerm.ToUpper()))
         .ToList();
        }

        public int SaveProductChanges()
        {
            return _context.SaveChanges();
        }
    }
}
