using System.Collections.Generic;
using System.Linq;
using ItemsAPI.Model;
using Microsoft.AspNetCore.Mvc;

namespace ItemsAPI.Controllers {
    [Route("api/items")]
    [ApiController]
    public class ItemsController : ControllerBase {

        static private List<Item> items = new List<Item>();

        /// <summary>
        /// Recupera Lista de Itens        
        /// </summary>       
        /// <returns>Lista de Itens</returns>
        // GET api/items
        [HttpGet]
        public ActionResult<List<Item>> Get() {
            return items;
        }

        /// <summary>
        /// Recupera um item específico
        /// </summary>       
        /// <param name="id">Id do Item</param>
        /// <returns>Retorna o item</returns>
        // GET api/items/1
        [HttpGet("{id}")]
        public ActionResult<Item> Get(int id) {
            return items[id];
        }

        /// <summary>
        /// Recupera um item específico
        /// </summary>       
        /// <param name="id">Id do Item</param>
        /// <returns>Retorna o item</returns>
        // GET api/items/1
        [HttpGet("range/{a}/to/{b}")]
        public ActionResult<List<Item>> Get(int a, int b) {
            return items.GetRange(a, b);
        }

        /// <summary>
        /// Insere um item
        /// </summary>       
        /// <param name="item">Id do Item</param>
        /// <returns>Retorna o id do item</returns>
        // POST api/items
        [HttpPost]
        public int Post([FromBody] Item item) {
            items.Add(item);
            int id = items.Count() - 1;
            return id;
        }

        /// <summary>
        /// Insere uma lista de itens
        /// </summary>       
        /// <param name="item">Id do Item</param>
        /// <returns>Retorna o id do item</returns>
        [HttpPost("list")]
        public int Post([FromBody] List<Item> listItems) {
            foreach (var item in listItems) {
                items.Add(item);                                                             
            }
            int lastId = items.Count() - 1;
            return lastId;
        }

        /// <summary>
        /// Atualiza um item
        /// </summary>       
        /// <param name="item">Id do Item</param>
        /// <returns>Retorna o id do item</returns>
        // PUT api/items/1
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Item item) {
            items[id] = item;
        }

        /// <summary>
        /// Remove um item
        /// </summary>       
        /// <param name="item">Id do Item</param>
        /// <returns>Retorna o id do item</returns>
        // DELETE api/items/1
        [HttpDelete("{id}")]
        public void Delete(int id) {
            items.RemoveAt(id);
        }
    }
}
