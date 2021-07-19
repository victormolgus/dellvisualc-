using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Oficina4._1
{
    [Table("Cliente")]
    class Cliente
    {
        [Key]
        public int cod_Cliente { get; set; }
        public String nome_cliente { get; set; }
        public String endereco { get; set; }
    }
}
