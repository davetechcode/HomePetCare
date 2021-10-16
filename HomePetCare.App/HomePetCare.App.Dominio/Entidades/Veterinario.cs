using System;

namespace RazorPagesMascotas.Models
{
    public class Veterinario
    {
       public int VeterinarioId { get; set; }
        public string TarjetaProfesional { get; set; }
        public int VisitaId { get; set; }
         public string Identificacion {get;set;}
        public string Nombre {get;set;}
        public string Apellidos {get;set;}
        public string Direccion {get;set;}
        public string Telefono {get;set;}
        
    }
}