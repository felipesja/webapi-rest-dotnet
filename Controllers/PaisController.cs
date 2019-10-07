using ItemsAPI.DAL;
using ItemsAPI.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItemsAPI.Controllers
{
    [Route("api/pais")]
    [ApiController]
    public class PaisController : ControllerBase
    {
        private ItemsAPIContext _context;

        public PaisController()
        {
            _context = new ItemsAPIContext();
        }

        [HttpGet]
        public ActionResult<List<Pais>> Get()
        {
            //try
            //{
            var pais = _context.Pais.ToList();

            return pais;
            //}
            /*catch(Exception ex)
            {
                var list = ex.Message;
                return list;
            }*/

        }
    }
}
