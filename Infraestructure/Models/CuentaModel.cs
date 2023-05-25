﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Models
{
    public class CuentaModel
    {
        public int id { get; set; }
        public int id_persona { get; set; }
        public string nombre_cuenta { get; set; }
        public string numero_cuenta { get; set; }
        public int saldo { get; set; }
        public int limite_saldo { get; set; }
        public int limite_transferencia { get; set; }
        public string estado { get; set; }
    }
}
