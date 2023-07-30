using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    [Table("Servicio")]
    public class Servicio
    {
        [Column("ID_Servicio"), Key]
        public int Id { get; set; }

        [Column("Descripction_Servicio")]
        public string Descripction { get; set; } = string.Empty;

        [Column("Valor_Unit")]
        public decimal Valor { get; set; }
    }
}
