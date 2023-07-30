using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidades
{
    [Table("Cliente")]
    public class Cliente
    {
        [Column("ID_Cliente"), Key]
        public int Id { get; set; }
        public string Nombres { get; set; } = string.Empty;
        public string Apellidos { get; set; } = string.Empty;
        public int Cedula { get; set; }
        public int Ruc { get; set; }
        public string Correo { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;

        [Column("ID_Ciudad")]
        public int IdCiudad { get; set; }
        public int Telefono { get; set; }

        #region Propiedades de navegación

        [ForeignKey("IdCiudad")]
        public virtual Ciudad Ciudad { get; set; }

        #endregion
    }
}
