using Dapper;
using Infraestructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public class OperacionesRepository
    {
        private string _connectionString;
        private Npgsql.NpgsqlConnection connection;
        public OperacionesRepository(string connectionString)
        {
            _connectionString = connectionString;
            connection = new Npgsql.NpgsqlConnection(_connectionString);
        }

       
        public string transferir(CuentaModel cuenta, int id)
        {
            try
            {

                connection.Execute($"UPDATE cuenta SET " +
                    "saldo = @saldo " +
                     $"WHERE id= {id}", cuenta);
                return "Se modificaron los datos correctamente...";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public string depositar(CuentaModel cuenta, int id)
        {
            try
            {

                connection.Execute($"UPDATE cuenta SET " +
                    "saldo = @saldo " +
                     $"WHERE id= {id}", cuenta);
                return "Se modificaron los datos correctamente...";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string retirar(CuentaModel cuenta, int id)
        {
            try
            {

                connection.Execute($"UPDATE cuenta SET " +
                    "saldo = @saldo " +
                    $"WHERE id= {id}", cuenta);
                return "Se modificaron los datos correctamente...";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



        public string bloquear(CuentaModel cuenta, int id)
        {
            try
            {

                connection.Execute($"UPDATE cuenta SET " +
                    "estado = @estado " +
                    $"WHERE id= {id}", cuenta);
                return "Se modificaron los datos correctamente...";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public CuentaModel consultarCuenta(int id)
        {
            try
            {
                return connection.QueryFirst<CuentaModel>($"SELECT * FROM cuenta WHERE id = {id}");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}
