using Dapper;
using System.Data;
using System.Data.SqlClient;
using ProductInfo.Models;

namespace ProductInfo.DAL
{
    public class ProductRepository
    {
        private readonly string _connectionString;

        public ProductRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        private IDbConnection Connection => new SqlConnection(_connectionString);

        public List<Product> GetAll()
        {
            using (var db = Connection)
            {
                string query = "SELECT Id, Name, Price FROM Products";
                return db.Query<Product>(query).AsList();
            }
        }

        public void Add(Product product)
        {
            using (var db = Connection)
            {
                string query = "INSERT INTO Products (Name, Price) VALUES (@Name, @Price)";
                db.Execute(query, product);
            }
        }

        public void Update(Product product)
        {
            using (var db = Connection)
            {
                string query = "UPDATE Products SET Name = @Name, Price = @Price WHERE Id = @Id";
                db.Execute(query, product);
            }
        }

        public void Delete(int id)
        {
            using (var db = Connection)
            {
                string query = "DELETE FROM Products WHERE Id = @Id";
                db.Execute(query, new { Id = id });
            }
        }
    }
}
