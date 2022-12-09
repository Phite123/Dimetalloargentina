using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace BlazorApp1.Shared.Models
{
    public partial class Cliente
    {
        public int Id { get; set; }
        public string? NombreEmpresa { get; set; }
        [Required(ErrorMessage = "Seleccione un CUIT.")]
        public string? Cuit { get; set; }
        [Required(ErrorMessage = "Seleccione una dirección.")]
        public string? Direccion { get; set; }
        [Required(ErrorMessage = "Seleccione un mail.")]
        public string? Mail { get; set; }
        [Required(ErrorMessage = "Seleccione un teléfono.")]
        public string? Telefono { get; set; }
        public string? Cp { get; set; }
        [Required(ErrorMessage = "Seleccione un nombre de contacto.")]
        public string? NombreContacto { get; set; }
        public string? Observaciones { get; set; }
        [Required(ErrorMessage = "Seleccione una razon social.")]
        public string? RazonSocial { get; set; }
        [Required(ErrorMessage = "Seleccione un corredor.")]
        public string? Corredor { get; set; }
    }
}
