using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class DetailRepositorie : IDetailRepositorie
    {
        private readonly string connectionString = @"Data Source=.\;Initial Catalog=Car_Detail;Integrated Security=True";

        public bool Create(Detail detail)
        {
            var query = $"INSERT INTO Detail (Name, Price, CarId) VALUES ({detail.Name}, '{detail.Price}',{detail.CarId})";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                var result = command.ExecuteNonQuery();
                connection.Close();
            };
            return true;
        }

        public bool Delete(int id)
        {
            var query = $"DELETE FROM Detail WHERE Id = {id}";

            SqlConnection connection = new SqlConnection(connectionString);

            using (connection)
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                var result = command.ExecuteNonQuery();
                connection.Close();
            }

            return true;
        }

        public IEnumerable<Detail> GetDetails()
        {
            var query = "SELECT * FROM Detail";
            var result = new List<Detail>();
            SqlConnection connection = new SqlConnection(connectionString);

            using (connection)
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        result.Add(new Detail
                        {
                            Id = (int)reader["Id"],
                            Name = (string)reader["Name"],
                            Price = (int)reader["Price"],
                            CarId = (int)reader["CarId"]        
                        });
                    }
                }
                connection.Close();

                return result;
            }
        }

        public bool Update(Detail detail)
        {
            var query = $"UPDATE Detail SET Name = '{detail.Name}', Cost = {detail.Price} WHERE ID = {detail.Id}";
            SqlConnection connection = new SqlConnection(connectionString);

            using (connection)
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                var rowsChanged = command.ExecuteNonQuery();
                connection.Close();

                return rowsChanged != 0;
            }
        }
    }
}
