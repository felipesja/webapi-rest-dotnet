using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace ItemsAPI.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase {

        static private List<Item> items = new List<Item>();

        // GET api/items
        [HttpGet]
        public ActionResult<List<Item>> Get() {
            return items;
        }

        // GET api/items/1
        [HttpGet("{id}")]
        public ActionResult<Item> Get(int id) {
            return items[id];
        }

        // GET api/items/1
        [HttpGet("range/{a}/to/{b}")]
        public ActionResult<List<Item>> Get(int a, int b) {
            return items.GetRange(a, b);
        }

        // POST api/items
        [HttpPost]
        public int Post([FromBody] Item item) {
            items.Add(item);
            int id = items.Count() - 1;
            return id;
        }

        [HttpPost("list")]
        public int Post([FromBody] List<Item> listItems) {
            foreach (var item in listItems) {
                items.Add(item);                                                             
            }
            int lastId = items.Count() - 1;
            return lastId;
        }

        // PUT api/items/1
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Item item) {
            items[id] = item;
        }

        // DELETE api/items/1
        [HttpDelete("{id}")]
        public void Delete(int id) {
            items.RemoveAt(id);
        }
    }
}
