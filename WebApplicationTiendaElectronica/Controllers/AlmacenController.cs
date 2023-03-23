using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebApplicationTiendaElectronica.Datos;
using WebApplicationTiendaElectronica.Models;

namespace WebApplicationTiendaElectronica.Controllers
{
    public class AlmacenController : ApiController
    {

        Tienda_ElectronicaEntities te = new Tienda_ElectronicaEntities();
        // GET api/<controller>
        public List<Almacen> Get()
        {
            return AlmacenController.Listar();
        }

        private static List<Almacen> Listar()
        {
            throw new NotImplementedException();
        }

        // GET api/<controller>/5
        public Almacen Get(int codigo)
        {
            return AlmacenController.Obtener( codigo);
        }

        private static Almacen Obtener(int codigo)
        {
            throw new NotImplementedException();
        }

        // POST api/<controller>
        public bool Post([FromBody] Almacen almacen)
        {
            return AlmacenData.Registrar(almacen);
        }

        // PUT api/<controller>/5
        public bool Put([FromBody] Almacen almacen)
        {
            return AlmacenData.Modificar(almacen);
        }

        // DELETE api/<controller>/5
        public bool Delete(int id)
        {
            return AlmacenData.Eliminar(id);
        }
    }
}