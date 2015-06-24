using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.DynamicData;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace PuntoDeEncuentro.Models
{
    [MetadataType(typeof(itbevento))]
    public partial class tbevento
    {
        public void prueba()
        {  
        }
    }
    public interface itbevento {
        [MinLength(2)]
        object titulo { get; set; }

        [Key]
        object idevento { get; set; }
        [DataType(DataType.Text, ErrorMessage = "error fecha")]
        object fechacreacion { get; set; }
        [Required]
        [DataType(DataType.Text, ErrorMessage = "error fecha")]
        object fechamodificacion { get; set; }
        [Required]
        object estado { get; set; }
    }
}