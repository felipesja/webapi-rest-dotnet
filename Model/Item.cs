using System.ComponentModel.DataAnnotations;

namespace ItemsAPI.Controllers {
    public class Item {
        [Key]
        private int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}