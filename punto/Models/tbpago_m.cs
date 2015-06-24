using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace PuntoDeEncuentro.Models
{
    [MetadataType(typeof(itbpago))]
    public partial class tbpago
    {
    }
    public interface itbpago {

        [Required]
        [Key]
        object idpagos { get; set; }
        [Required]
        object nombre { get; set; }
        [Required]
        object imagen { get; set; }
        [DataType(DataType.Text, ErrorMessage = "error fecha")]
        object fechacreacion { get; set; }
        [Required]
        [DataType(DataType.Text, ErrorMessage = "error fecha")]
        object fechamodificacion { get; set; }
        [Required]
        object estado { get; set; }


    }
}