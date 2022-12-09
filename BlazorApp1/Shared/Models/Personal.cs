using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace BlazorApp1.Shared.Models
{
    public partial class Personal
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Seleccione un nombre.")]
        public string? Nombres { get; set; }
        [Required(ErrorMessage = "Seleccione un apellido.")]
        public string? Apellido { get; set; }
        [Required(ErrorMessage = "Seleccione un DNI.")]
        public int? Dni { get; set; }
        public string? Mail { get; set; }
        [Required(ErrorMessage = "Seleccione un teléfono.")]
        public string? Telefono { get; set; }
        public string? Direccion { get; set; }
        public string? CondicionContractual { get; set; }
        public int? Legajo { get; set; }
        public string? Puesto { get; set; }
        public string? Categoria { get; set; }
        public string? PremioEstablecido { get; set; }
    }
}
