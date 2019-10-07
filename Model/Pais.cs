using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ItemsAPI.Model
{
    [Table("Pais")]
    public class Pais
    {
        [Key]
        public int id_pais { get; set; }
        public string nome_pais { get; set; }
    }
}
