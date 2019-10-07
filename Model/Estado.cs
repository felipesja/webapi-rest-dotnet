using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ItemsAPI.Model
{
    [Table("estado")]
    public class Estado
    {
        [Key]
        public int id_estado { get; set; }
        public string nome_estado { get; set; }
        [ForeignKey("pais")]
        public int id_pais { get; set; }

        public Pais pais { get; set; }
    }
}
