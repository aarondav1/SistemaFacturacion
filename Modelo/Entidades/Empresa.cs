using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    [Table("Empresa")]
    public class Empresa
    {
        [Column("ID_Empresa"), Key]
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;

        [Column("Descripcion_Emp")]
        public string Descripcion { get; set; } = string.Empty;
    }
}
