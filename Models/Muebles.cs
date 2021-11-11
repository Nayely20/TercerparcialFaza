using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFaza.Models
{
    public class Muebles
    {
        [Key]
        public string Mueble { get; set; }
        [Display(Name = "escriba el tipo de mueble")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "El nombre debe contener entre 3 a 60 caracteres")]
        [Required(ErrorMessage = "el tipo es necesario")]
        public string Marca { get; set; }
        [Display(Name = "marca del mueble")]
        public string Precio { get; set; }
        [Url]
        [Display(Name = "enlace de la pagina web")]
        public string Enlace { get; set; }
    }
}
