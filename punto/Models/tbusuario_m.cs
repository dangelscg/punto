using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace PuntoDeEncuentro.Models
{
     [MetadataType(typeof(itbusuario))]
    public partial class tbusuario
    {
    }
     public interface itbusuario
     {
         [Required]
         [Key]
         object idusaurio { get; set; }
         [Required]
         object login { get; set; }
         [Required]
         object pass { get; set; }
         [Required]
         object fid { get; set; }
         [Required]
         [EmailAddress]
         object femail { get; set; }
         [Required]
         object fullname { get; set; }
         [Required]
         object gid { get; set; }
         [Required]
         [EmailAddress]
         object gemail { get; set; }
         [Required]
         [DataType(DataType.Text, ErrorMessage = "error fecha")]
         object creado { get; set; }
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