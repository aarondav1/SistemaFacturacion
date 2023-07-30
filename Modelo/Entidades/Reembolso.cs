using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    [Table("Reembolso")]
    public class Reembolso
    {
        [Column("ID_Reembolso")]
        public int Id { get; set; }

        [Column("ID_Factura")]
        public int IdFactura { get; set; }

        [Column("ID_Servicio")]
        public int IdServicio { get; set; }

        [Column("Descripcion_Re")]
        public string Descripcion { get; set; } = string.Empty;

        #region Propiedades de navegación

        [ForeignKey("IdFactura")]
        public virtual Factura Factura { get; set; }

        [ForeignKey("IdServicio")]
        public virtual Servicio Servicio { get; set; }

        #endregion
    }
}
