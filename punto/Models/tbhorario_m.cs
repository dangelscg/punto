using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace PuntoDeEncuentro.Models
{
    [MetadataType(typeof(itbhorario))]
    public partial class tbhorario
    {
    }
    public interface itbhorario
    {
        [Required]
        [Key]
        object idhorario { get; set; }
        [Required]
        [DataType(DataType.Text, ErrorMessage = "error fecha")]
        object inicio { get; set; }
        [Required]
        [DataType(DataType.Text, ErrorMessage = "error fecha")]
        object fin { get; set; }
        [Required]
        [RegularExpression("[0-9]", ErrorMessage = "Error")]
        object idlugares { get; set; }
        [Required]
        [RegularExpression("[0-9]", ErrorMessage = "Error")]
        object tipo { get; set; }
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