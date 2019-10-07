using ItemsAPI.DAL;
using ItemsAPI.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItemsAPI.Controllers
{
    [Route("api/estado")]
    [ApiController]
    public class EstadoController : ControllerBase
    {
        private ItemsAPIContext _context;

        public EstadoController()
        {
            _context = new ItemsAPIContext();
        }

        [HttpGet("{id_pais}")]
        public ActionResult<List<Estado>> Get(int id_pais)
        {
            //try
            //{
                var estados = _context.Estado.Where(e => e.id_pais.Equals(id_pais))
                .ToList();

                return estados;
            //}
            /*catch(Exception ex)
            {
                var list = ex.Message;
                return list;
            }*/
            
        }
    }
}
