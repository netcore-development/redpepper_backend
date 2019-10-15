using System;
using System.ComponentModel.DataAnnotations;

namespace RedPepper.API.Model
{
    public class Persona
    {
        [Required]
        public int Id {get;set;}
        [Required]
        [MaxLength(50)]
        public string Nombres {get;set;}
        [Required]
        [MaxLength(50)]
        public string Apellidos {get;set;}
        [StringLength(1)]
        public string Sexo {get;set;}
        [Required]
        public DateTime FechaNacimiento {get;set;}
        [MaxLength(10)]
        public string Dui {get;set;}
        [MaxLength(17)]
        public string Nit {get;set;}
        [Required]
        [MaxLength(250)]
        public string Direccion {get;set;}
        [MaxLength(9)]
        public string Telefono {get;set;}
        [MaxLength(100)]
        public string CorreoElectronico {get;set;}
    }
}