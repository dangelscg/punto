using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace punto.Models
{
    [MetadataType(typeof(itvoto))]
    public partial class tbvotos
    {
       //
        puntoencuentroEntities db = new puntoencuentroEntities();
        public void prueba2()
        {

        }
    }


    public interface itvoto
    {

            [Key]
            [ScaffoldColumn(false)]
            object id { get; set; }


            [Required]
            [MinLengthAttribute(2)]
            object titulo { get; set; }


            [Required]
            object total_votes { get; set; }


            [Required]
            object total_value { get; set; }
            [MinLengthAttribute(2)]
            object used_ips { get; set; }

            [DataType(DataType.DateTime, ErrorMessage = "debe introducir una fecha valida")]
            object fechacreacion { get; set; }

            [DataType(DataType.DateTime, ErrorMessage = "debe introducir una fecha valida")]
            object fechamodificacion { get; set; }

            [Required]
            object estado { get; set; }




        
    }
}