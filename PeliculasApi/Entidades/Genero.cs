using PeliculasApi.Validaciones;
using System.ComponentModel.DataAnnotations;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace PeliculasApi.Entidades
{
    public class Genero 
    {
        public int Id { get; set; }
        [Required (ErrorMessage =" el campo {0} es requerido")]
        [StringLength(maximumLength:10)]
        [PrimeraLetraMayusculaAtributte]
        public string Nombre { get; set; }
     
    }

    
}
