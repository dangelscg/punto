using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace punto.Models
{
    [MetadataType(typeof(itbpersona))]
    public partial class tbpersona
    {
        void ss()
        { }
    }
    public interface itbpersona
    {
        [Display(Name = "Tsgjdasasdasj Nombre")]
        
        [Required]
        object nombre { get; set; }
        [Display(Name = "Apellido Paterno")]
        [Required]
        object paterno { get; set; }
        [Display(Name = "Apellido Materno")]
        [Required]
        object materno { get; set; }
        [Required]
        [RegularExpression(@"[0-9]*\.?[0-9]+",ErrorMessage="ci incorrecto")]
        [Editable(false)]// no se podra editar
        [Range(60000, 15000000)]
        object ci { get; set; }
        [Required]
        [DataType(DataType.Text, ErrorMessage = "error fecha de nacimiento")]
        object fechanac { get; set; }
        [Required]
        [DataType(DataType.Text, ErrorMessage = "error fecha de creacion")]
        object fechacreacion { get; set; }
        [Required]
        [DataType(DataType.Text, ErrorMessage = "error fecha de modificacion")]
        object fechamodificacion { get; set; }
       // [DisplayColumn("Campo de Nombre","Nom.")]       
        //[MaxLength(20,ErrorMessage="no maximo de 20 caracteres")]
        //[StringLength(20)]
        [Required]
        [Range(0,2)]
        object estado { get; set; }

        [Key]
        [ScaffoldColumn(false)]
        object idpersona { get; set; }
    }
}