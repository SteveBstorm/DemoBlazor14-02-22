using DataAccessLayer.Abstraction;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Services
{
    public class ProductService : IProductRepo
    {
        private readonly string _connectionString = @"Data Source=DESKTOP-RGPQP6I\TFTIC2019;Initial Catalog=DemoAperam;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public Product GetById(int Id)
        {
            Product p = new Product();
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                cnx.Open();
                using (SqlCommand cmd = cnx.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Product WHERE Id = @Id";
                    cmd.Parameters.AddWithValue("Id", Id);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            p.Id = (int)reader["Id"];
                            p.Name = (string)reader["Name"];
                            p.Price = (int)reader["Price"];
                        }
                    }
                }
                cnx.Close();
            }
            return p;
        }

        public void PublishData(string name, int price)
        {
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                cnx.Open();
                using (SqlCommand cmd = cnx.CreateCommand())
                {
                    
                        cmd.CommandText = "INSERT INTO Product (Name, Price) VALUES (@n, @p)";
                        cmd.Parameters.AddWithValue("n", name);
                        cmd.Parameters.AddWithValue("p", price);

                        cmd.ExecuteNonQuery();
                    

                }
                cnx.Close();
            }
        }

        public IEnumerable<Product> GetAll()
        {
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnx.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Product";
                    cnx.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return new Product
                            {
                                Id = (int)reader["Id"],
                                Name = (string)reader["Name"],
                                Price = (int)reader["Price"]
                            };
                        }
                    }
                }
                cnx.Close();
            }
        }
    }
}
