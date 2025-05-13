using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using BancoApp.Models;

namespace BancoApp.DataAccess
{
    public class CuentaRepository
    {
        //public List<CuentaBancaria> GetByClienteId(int clienteId)
        //{
        //    List<CuentaBancaria> cuentas = new List<CuentaBancaria>();

        //    using (SqlConnection conn = SqlConnectionManager.GetConnection())
        //    {
        //        conn.Open();
        //        string query = @"
        //                SELECT 
        //                CONCAT(c.FirstName, ' ', c.LastName) AS NombreCliente,
        //                c.Id AS ClienteId,
        //                cu.AccountNumber,
        //                cu.Description
        //                    FROM Cuentas cu
        //                    JOIN Clientes c ON c.Id = cu.ClienteId
        //                    WHERE c.Id = @id";

        //        using (SqlCommand cmd = new SqlCommand(query, conn))
        //        {
        //            cmd.Parameters.AddWithValue("@id", clienteId);
        //            using (SqlDataReader reader = cmd.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    cuentas.Add(new CuentaBancaria
        //                    {
        //                        Id = (int)reader["Id"],
        //                        ClienteId = (int)reader["ClienteId"],
        //                        AccountNumber = reader["AccountNumber"].ToString(),
        //                        Description = reader["Description"].ToString()
        //                    });
        //                }
        //            }
        //        }
        //    }

        //    return cuentas;
        //}

        public DataTable GetCuentasInfoByClienteId(int clienteId)
        {
            using (SqlConnection conn = SqlConnectionManager.GetConnection())
            {
                conn.Open();
                string query = @"
            SELECT 
                CONCAT(c.FirstName, ' ', c.LastName) AS NombreCliente,
                c.Id AS ClienteId,
                cu.AccountNumber,
                cu.Description
            FROM Cuentas cu
            JOIN Clientes c ON c.Id = cu.ClienteId
            WHERE c.Id = @id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", clienteId);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

    }
}
