using Infraestructure.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Service;

namespace api.cuentas.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OperacionesController : Controller
    {
        private OperacionesService OperacionesService;
        private IConfiguration configuration;

        public OperacionesController(IConfiguration configuration)
        {
            this.configuration = configuration;
            this.OperacionesService = new OperacionesService(configuration.GetConnectionString("postgresDB"));
        }

        [HttpPut("transferir/{id}")]
        public ActionResult<string> transferir(CuentaModel modelo, int id)
        {
            var resultado = this.OperacionesService.transferir(new Infraestructure.Models.CuentaModel
            {
                //id_persona = modelo.id_persona,
                //nombre_cuenta = modelo.nombre_cuenta,
                numero_cuenta = modelo.numero_cuenta,
                saldo = modelo.saldo,
                //limite_saldo = modelo.limite_saldo,
                //limite_transferencia = modelo.limite_transferencia,
                //estado = modelo.estado

            }, id);
            return Ok(resultado);
        }

        [HttpPut("depositar/{id}")]
        public ActionResult<string> depositar(CuentaModel modelo, int id)
        {
            var resultado = this.OperacionesService.depositar(new Infraestructure.Models.CuentaModel
            {
                //id_persona = modelo.id_persona,
                //nombre_cuenta = modelo.nombre_cuenta,
                numero_cuenta = modelo.numero_cuenta,
                saldo = modelo.saldo,
                //limite_saldo = modelo.limite_saldo,
                //limite_transferencia = modelo.limite_transferencia,
                //estado = modelo.estado

            }, id);
            return Ok(resultado);
        }

        [HttpPut("retirar/{id}")]
        public ActionResult<string> retirar(CuentaModel modelo, int id)
        {
            var resultado = this.OperacionesService.depositar(new Infraestructure.Models.CuentaModel
            {
                //id_persona = modelo.id_persona,
                //nombre_cuenta = modelo.nombre_cuenta,
                numero_cuenta = modelo.numero_cuenta,
                saldo = modelo.saldo,
                //limite_saldo = modelo.limite_saldo,
                //limite_transferencia = modelo.limite_transferencia,
                //estado = modelo.estado

            }, id);
            return Ok(resultado);
        }

        [HttpPut("bloquear/{id}")]
        public ActionResult<string> bloquear(CuentaModel modelo, int id)
        {
            var resultado = this.OperacionesService.depositar(new Infraestructure.Models.CuentaModel
            {
                //id_persona = modelo.id_persona,
                //nombre_cuenta = modelo.nombre_cuenta,
                //numero_cuenta = modelo.numero_cuenta,
                //saldo = modelo.saldo,
                //limite_saldo = modelo.limite_saldo,
                //limite_transferencia = modelo.limite_transferencia,
                estado = modelo.estado

            }, id);
            return Ok(resultado);
        }

        [HttpGet("ConsultarCuenta/{id}")]
        public ActionResult<CuentaModel> consultarCuenta(int id)
        {
            var resultado = this.OperacionesService.consultarCuenta(id);
            return Ok(resultado);
        }

    }
}
