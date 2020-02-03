using System.Collections.Generic;
using System.Linq;

namespace StockManagement
{
    public class ProductRepository: IProductRepository
    {
        private readonly ProductContext _productContext;

        public ProductRepository(ProductContext productContext)
        {
            _productContext = productContext;
        }

        public Product AddProduct(int P_id, string P_name, int P_price, int P_quantity)
        {
            var newproduct = _productContext.Add(new Product
            {
                ProductId = P_id,
                ProductName = P_name,
                ProductPrice = P_price,
                ProductQuantity = P_quantity,
            });
            _productContext.SaveChanges();
            return newproduct.Entity;
        }



        public IEnumerable<Product> selectProduct
        {
            get { return _productContext.Products; }
        }
        public Product updateProduct(Product product)
        {

            return _productContext.Update(product).Entity;
        }

        public Product deleteProduct(Product product)
        {
            return _productContext.Remove(product).Entity;
        }

        public Product getProductById(int productId)
        {
            return _productContext.Products.FirstOrDefault(p => p.ProductId == productId);
        }
    }
}