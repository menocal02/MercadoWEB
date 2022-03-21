using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MercadoWEB.Models.Entidades
{
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(600)]
        public string NombreCompleto { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(600)]
        public string Direccion { get; set; }
    }
}
