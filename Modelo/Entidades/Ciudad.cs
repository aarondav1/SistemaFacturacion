using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    [Table("Ciudad")]
    public class Ciudad
    {
        [Column("ID_Ciudad"), Key]
        public int Id { get; set; }
        [Column("Nombre_Ciu")]
        public string Nombre { get; set; } = string.Empty;
    }
}
