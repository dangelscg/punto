using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace punto.Models
{
    [MetadataType(typeof(itbcategorias))]
    public class tbcategorias
    {
        public void prueba()
        {

        }
    }
    public interface itbcategorias
    {
        [Display(Name = "idcategorias")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Error")]//tipo de dato
        //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [MaxLength(20, ErrorMessage = "no maximo de 20 caracteres")]
        [StringLength(20)]//max 20
        [Editable(false)]
        [Required]
        [Range(60000, 15000000)]
        
        [ScaffoldColumn(false)]
        object idcategorias { get; set; }
    
        [Display(Name = "nombre")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Error")]//tipo de dato
        //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [MaxLength(20, ErrorMessage = "no maximo de 20 caracteres")]
        [StringLength(20)]//max 20
        [Editable(false)]
        [Required]
        [Range(60000, 15000000)]
        [ScaffoldColumn(false)]
        object nombre { get; set; }//nombre de la column
        
        
    
        [Display(Name = "responsable")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Error")]//tipo de dato
        //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [MaxLength(20, ErrorMessage = "no maximo de 50 caracteres")]
        [StringLength(20)]//max 20
        [Editable(false)]
        [Required]
        [Range(60000, 15000000)]
        object responsable { get; set; }//nombre de la column
        
   
        [Display(Name = "padre")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Error")]//tipo de dato
        //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [MaxLength(20, ErrorMessage = "no maximo de 20 caracteres")]
        [StringLength(20)]//max 20
        [Editable(false)]
        [Required]
        [Range(60000, 15000000)]
        object padre { get; set; }//nombre de la column
        
    
        [Display(Name = "fechacreacion")]//nombre de los labels
        [DataType(DataType.Date, ErrorMessage = "Error")]//tipo de dato
        //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [MaxLength(20, ErrorMessage = "no maximo de 20 caracteres")]
        [StringLength(20)]//max 20
        [Editable(false)]
        [Required]
        [Range(60000, 15000000)]
        object fechacreacion { get; set; }//nombre de la column
        
   
        [Display(Name = "fechamodificacion")]//nombre de los labels
        [DataType(DataType.Date, ErrorMessage = "Error")]//tipo de dato
        //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [MaxLength(20, ErrorMessage = "no maximo de 20 caracteres")]
        [StringLength(20)]//max 20
        [Editable(false)]
        [Required]
        [Range(60000, 15000000)]
        object fechamodificacion { get; set; }//nombre de la column
        
   
        [Display(Name = "estado")]//nombre de los labels
        [DataType(DataType.Text, ErrorMessage = "Error")]//tipo de dato
        //[DisplayColumn("campo de nombre","Nom.")]//nombre en la columna
        [MaxLength(20, ErrorMessage = "no maximo de 20 caracteres")]
        [StringLength(20)]//max 20
        [Editable(false)]
        [Required]
        [Range(60000, 15000000)]
        object estado { get; set; }//nombre de la column
        
    }
}