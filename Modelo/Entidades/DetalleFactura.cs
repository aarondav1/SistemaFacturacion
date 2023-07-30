using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    [Table("Detalle_Factura")]
    public class DetalleFactura
    {
        [Column("ID_Detalle_Factura")]
        public int Id { get; set; }

        [Column("ID_Factura")]
        public int IdFactura { get; set; }

        [Column("ID_Servicio")]
        public int IdServicio { get; set; }

        public int Cantidad { get; set; }

        [Column("Precio_Pagar")]
        public decimal PrecioPagar { get; set; }

        #region Propiedades de navegación

        [ForeignKey("IdFactura")]
        public virtual Factura Factura { get; set; }

        [ForeignKey("IdServicio")]
        public virtual Servicio Servicio { get; set; }

        #endregion
    }
}
