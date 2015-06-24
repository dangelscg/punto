using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace PuntoDeEncuentro.Models
{
    [MetadataType(typeof(ivotos))]
    public partial class votos
    {
    }
    public interface ivotos
    {
        [Required]
        [RegularExpression(@"[0-9]*\.?[0-9]+", ErrorMessage = "Error dato incorrecto")]
        object id { get; set; }
        [Required]
        object titulo{get;set;}
        [Required]
        [RegularExpression(@"[0-9]*\.?[0-9]+", ErrorMessage = "Error dato incorrecto")]
        object total_votes { get; set; }
        [Required]
        [RegularExpression(@"[0-9]*\.?[0-9]+", ErrorMessage = "Error dato incorrecto")]
        object total_value { get; set; }
        [Required]
        object used_ips { get; set; }
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