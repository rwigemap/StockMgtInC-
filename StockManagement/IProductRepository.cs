using System.Collections;
using System.Collections.Generic;

namespace StockManagement
{
    public interface IProductRepository
    {
        Product AddProduct(int P_id, string P_name, int P_price, int P_quantity);
        IEnumerable<Product>selectProduct { get; }
        Product updateProduct(Product product);
        Product deleteProduct(Product product);
        Product getProductById(int productId);
    }
}