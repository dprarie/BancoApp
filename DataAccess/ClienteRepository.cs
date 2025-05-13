using System;
using System.Data;
using System.Data.SqlClient;
using BancoApp.Models;

namespace BancoApp.DataAccess
{
    public class ClienteRepository
    {
        // Obtener cliente por ID
        public Cliente GetById(int id)
        {
            using (SqlConnection conn = SqlConnectionManager.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Clientes WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                            return MapCliente(reader);
                    }
                }
            }
            return null;
        }

        // Autenticación por username y password
        public Cliente Login(string username, string password)
        {
            using (SqlConnection conn = SqlConnectionManager.GetConnection())
            {
                conn.Open();
                string query = @"
                SELECT * FROM Clientes 
                WHERE Username COLLATE Latin1_General_CS_AS = @u AND Password = @p";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@u", username);
                    cmd.Parameters.AddWithValue("@p", password);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                            return MapCliente(reader);
                    }
                }
            }
            return null;
        }

        // Insertar nuevo cliente
        public void Insert(Cliente cliente)
        {
            using (SqlConnection conn = SqlConnectionManager.GetConnection())
            {
                conn.Open();
                string query = @"
                    INSERT INTO Clientes (FirstName, LastName, Username, Password, Country, Region, City, Address)
                    VALUES (@FirstName, @LastName, @Username, @Password, @Country, @Region, @City, @Address)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FirstName", cliente.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", cliente.LastName);
                    cmd.Parameters.AddWithValue("@Username", cliente.Username);
                    cmd.Parameters.AddWithValue("@Password", cliente.Password);
                    cmd.Parameters.AddWithValue("@Country", cliente.Country ?? "");
                    cmd.Parameters.AddWithValue("@Region", cliente.Region ?? "");
                    cmd.Parameters.AddWithValue("@City", cliente.City ?? "");
                    cmd.Parameters.AddWithValue("@Address", cliente.Address ?? "");

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Actualizar cliente con control de concurrencia
        public bool Update(Cliente cliente, DateTime originalTimestamp)
        {
            using (SqlConnection conn = SqlConnectionManager.GetConnection())
            {
                conn.Open();
                string query = @"
                    UPDATE Clientes
                    SET FirstName = @FirstName, LastName = @LastName, Username = @Username, Password = @Password,
                        Country = @Country, Region = @Region, City = @City, Address = @Address,
                        LastUpdated = GETDATE()
                    WHERE Id = @Id AND LastUpdated = @OriginalTimestamp";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", cliente.Id);
                    cmd.Parameters.AddWithValue("@FirstName", cliente.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", cliente.LastName);
                    cmd.Parameters.AddWithValue("@Username", cliente.Username);
                    cmd.Parameters.AddWithValue("@Password", cliente.Password);
                    cmd.Parameters.AddWithValue("@Country", cliente.Country ?? "");
                    cmd.Parameters.AddWithValue("@Region", cliente.Region ?? "");
                    cmd.Parameters.AddWithValue("@City", cliente.City ?? "");
                    cmd.Parameters.AddWithValue("@Address", cliente.Address ?? "");
                    cmd.Parameters.AddWithValue("@OriginalTimestamp", originalTimestamp);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        // Eliminar cliente
        public void Delete(int id)
        {
            using (SqlConnection conn = SqlConnectionManager.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM Clientes WHERE Id = @Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Utilidad: mapear DataReader a objeto Cliente
        private Cliente MapCliente(SqlDataReader reader)
        {
            return new Cliente
            {
                Id = (int)reader["Id"],
                FirstName = reader["FirstName"].ToString(),
                LastName = reader["LastName"].ToString(),
                Username = reader["Username"].ToString(),
                Password = reader["Password"].ToString(),
                Country = reader["Country"].ToString(),
                Region = reader["Region"].ToString(),
                City = reader["City"].ToString(),
                Address = reader["Address"].ToString(),
                LastUpdated = Convert.ToDateTime(reader["LastUpdated"])
            };
        }
    }
}
