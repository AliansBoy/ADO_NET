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
    public class CarRepositorie : ICarRepositorie
    {
        private readonly string connectionString = @"Data Source=.\;Initial Catalog=Car_Detail;Integrated Security=True";
        public bool Create(Car car)
        {
            var query = $"INSERT INTO Car VALUES ('{car.Manufacturer}')";

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

        public bool Delete(int id)
        {
            var query = $"DELETE FROM Car WHERE Id = {id}";

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

        public IEnumerable<Car> GetCars()
        {
            var query = $"SELECT * FROM Car JOIN Detail ON Detail.CarId = Car.Id";
            var result = new List<Car>();

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
                        result.Add(new Car
                        {
                            Id = (int)reader["Id"],
                            Manufacturer = (string)reader["Manufacturer"]
                        });
                    }
                }
                connection.Close();

                return result;
            }
        }

        public bool Update(Car car)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            using (connection)
            {
                connection.Open();

                var cars = GetCars();

                var query = $"UPDATE Car SET Manufacturer = '{car.Manufacturer}'  where Id = {car.Id}";

                var command = new SqlCommand(query, connection);

                var rowsChanged = command.ExecuteNonQuery();

                return rowsChanged != 0;
            }
        }
    }
}
