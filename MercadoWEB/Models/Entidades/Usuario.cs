using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MercadoWEB.Models.Entidades
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        [Required]
        public int IdRol { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(600)]        
        public string NombreUser { get; set; }
        [Required]
        [StringLength(200)]
        public string Clave { get; set; }
        [Required]
        [StringLength(200)]
        public string Correo { get; set; }
        [Required]        
        public bool CambioClave { get; set; }
        [Required]       
        public bool Estado { get; set; }
        [Required]
        public DateTime FechaCreacion { get; set; }
    }
}
