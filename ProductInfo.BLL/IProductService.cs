using ProductInfo.Models;

namespace ProductInfo.BLL
{
    public interface IProductService
    {
        public List<Product> GetProducts();
        public void AddProduct(Product product);
        public void UpdateProduct(Product product);
        public void DeleteProduct(int id);
    }
}
