using ProductInfo.DAL;
using ProductInfo.Models;

namespace ProductInfo.BLL
{
    public class ProductService: IProductService
    {
        private readonly ProductRepository _repository;

        // ✅ Inject ProductRepository using Constructor
        public ProductService(ProductRepository repository)
        {
            _repository = repository;
        }

        public List<Product> GetProducts() => _repository.GetAll();
        public void AddProduct(Product product) => _repository.Add(product);
        public void UpdateProduct(Product product) => _repository.Update(product);
        public void DeleteProduct(int id) => _repository.Delete(id);
    }
}