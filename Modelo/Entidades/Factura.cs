using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    [Table("Factura")]
    public class Factura
    {
        [Column("ID_Factura"), Key]
        public int Id { get; set; }
 
        [Column("ID_Empresa")]
        public int IdEmpresa { get; set; }

        [Column("ID_Cliente")]
        public int IdCliente { get; set; }

        public DateTime Fecha { get; set; }

        [Column("ID_Pago")]
        public int IdPago { get; set; }


        #region Propiedades de navegación

        [ForeignKey("IdEmpresa")]
        public virtual Empresa Empresa { get; set; }

        [ForeignKey("IdCliente")]
        public virtual Cliente Cliente { get; set; }

        [ForeignKey("IdPago")]
        public virtual Pago Pago { get; set; }

        #endregion
    }
}
