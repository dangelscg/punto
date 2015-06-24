using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace PuntoDeEncuentro.Models
{
    [MetadataType(typeof(itb_categorias))]
    public partial class tb_categorias
    {
    }
    public interface itb_categorias
    {
        [Required]
        [Key]
        object idcategorias { get; set; }
        [Required]
              object nombre { get; set; }
        [Required]
        [RegularExpression(@"[0-9]*\.?[0-9]+", ErrorMessage = "Error dato incorrecto")]
        object responsable { get; set; }
        [Required]
        [RegularExpression(@"[0-9]*\.?[0-9]+", ErrorMessage = "Error dato incorrecto")]
        object padre { get; set; }
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