using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IngresosGastosJC.Models
{
    public class IngresosGastosJCL
    {   [Key]
        public int Id { get; set; }

        [Required]
        [StringLength (60, MinimumLength = 3)]
        public string Descripcion { get; set; }
         
        [Required]
        [Display(Name = "Tipo")]
        public bool EsIngreso { get; set; }

        [Required]
        public double Valor { get; set; }
        
        [Display(Name = "Fecha De Ingreso")]
        public DateTime FechaIngreso { get; set; }
    }
}