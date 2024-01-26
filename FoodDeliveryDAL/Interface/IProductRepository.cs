using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliveryDAL.Interface
{
    public interface IProductRepository {

         int SaveProductChanges();
        Product CreateProduct(Product product);
        Product GetProductById(int productId);
        IEnumerable<Product> GetAllProducts();

        Product UpdateProduct(Product product);
        IEnumerable<Product> SearchProducts(string searchTerm);
        Product DeleteProduct(int productId);
    }
    }

