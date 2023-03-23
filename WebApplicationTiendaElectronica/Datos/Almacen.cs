using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationTiendaElectronica.Dto
{
    public class Almacen
    {
         
        public int Codigo { get; set; }
        public string Nombre { get; set; }        
        public string Descripcion { get; set; }

        public string Cantidad{ get; set; }
        public string Precio { get; set; }
       

    }
}
