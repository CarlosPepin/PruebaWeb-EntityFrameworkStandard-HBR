//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Prueba_Web_HBR.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class tblUsuario
    {
        public int idUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string ApellidoUsuario { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}",ApplyFormatInEditMode = true)]
        public System.DateTime FechaNacimiento { get; set; }
        public System.DateTime FechaRegistro { get; set; }
        public int Edad { get; set; }
        public string Telefono { get; set; }
        public string Cedula { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        [DataType(DataType.Password)]
        public string Contraseña { get; set; }
        [DataType(DataType.Password)]
        [Compare("Contraseña")]
        public string ConfirmarContraseña { get; set; }
    }
}