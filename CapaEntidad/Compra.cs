﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Compra
    {
        public int idCompra { get; set; }
        public Usuario oUsuario { get; set; }
        public Proveedor idProveedor { get; set; }
        public string tipoDocumento { get; set; }
        public string nroDocumento { get; set; }

        



        public decimal montoTotal { get; set; }
        
        public List<DetalleCompra> oLista { get; set; }
        public string fechaRegistro { get; set; }



    }
}
