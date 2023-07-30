using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelo.Entidades
{
    [Table("Pago")]
    public class Pago
    {
        [Column("ID_Pago"), Key]
        public int Id { get; set; }

        [Column("Tipo_Pago")]
        public string TipoPago { get; set; } = string.Empty;
    }
}
