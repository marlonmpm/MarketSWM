using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;//Propiedades y palabras que nos permiten restringir los campos
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Shared.Entities
{
    public class Country//Entidad pais():
    {
        public int Id { get; set; }//Primary key, identity(1,1)

        //{}(Interpolacion de cadenas en c#)

        //El display es como una etiqueta(Titulo al campo)
        [Display (Name="Pais")]//Son etiquetas del nombre del campo
        [MaxLength (100,ErrorMessage ="El campo {0} debe contener únicamente 100 " +
            "caracteres")]//Es la Longitud de caractesres del campo
        [Required(ErrorMessage ="El campo {0} es obligatorio")] //Poner campo obligatorio

        public string? Name { get; set; } //? (Indica que hace un salto de nulos)
    }
}
