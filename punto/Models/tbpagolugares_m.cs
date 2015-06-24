using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace PuntoDeEncuentro.Models
{
    [MetadataType(typeof(itbpagolugares))]
    public partial class tbpagolugares
    {
    }
    public interface itbpagolugares
    {
        [Required]
        [Key]
        object idlugarpagos { get; set; }
        [Required]
        [RegularExpression(@"[0-9]*\.?[0-9]+", ErrorMessage = "Error dato incorrecto")]
        object idpago { get; set; }
        [Required]
        [RegularExpression(@"[0-9]*\.?[0-9]+", ErrorMessage = "Error dato incorrecto")]
        object idlugares { get; set; }
        [Required]
        [DataType(DataType.Text, ErrorMessage = "error fecha")]
        object fechacreacion { get; set; }
        [Required]
        [DataType(DataType.Text, ErrorMessage = "error fecha")]
        object fechamodificacion { get; set; }
        [Required]
        object estado { get; set; }
    }
}