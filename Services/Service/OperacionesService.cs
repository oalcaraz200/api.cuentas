using Infraestructure.Models;
using Infraestructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Service
{
    public class OperacionesService
    {

        private OperacionesRepository repositoryOperaciones;

        public OperacionesService(string connectionString)
        {
            this.repositoryOperaciones = new OperacionesRepository(connectionString);
        }


        public string transferir(CuentaModel cuenta, int id)
        {

            return repositoryOperaciones.transferir(cuenta, id);

        }

        public string depositar(CuentaModel cuenta, int id)
        {

            return repositoryOperaciones.depositar(cuenta, id);

        }


        public string retirar(CuentaModel cuenta, int id)
        {

            return repositoryOperaciones.retirar(cuenta, id);

        }

        public string bloquear(CuentaModel cuenta, int id)
        {

            return repositoryOperaciones.bloquear(cuenta, id);

        }

        public CuentaModel consultarCuenta(int id)
        {
            return repositoryOperaciones.consultarCuenta(id);
        }

    }
}
