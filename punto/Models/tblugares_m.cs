using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace PuntoDeEncuentro.Models
{
       [MetadataType(typeof(itblugares))]
    public partial class tblugares
    {
    }
       public interface itblugares
       {
           [Required]
           [Key]
           object idlugar { get; set; }
           [Required]
           object titulo { get; set; }
           [Required]
           object direccion { get; set; }
           [Required]
           object descripcion { get; set; }
           [Required]
           object web { get; set; }
           [Required]
           [RegularExpression("[0-9]", ErrorMessage = "Error")]
           object imagen { get; set; }
           [Required]
           [EmailAddress]
           object email { get; set; }
           [Required]
           object lat { get; set; }
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