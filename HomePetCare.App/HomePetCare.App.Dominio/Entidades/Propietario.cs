using System;

namespace RazorPagesMascotas.Models
{
    public class Propietario 
    {
      public int  PropietarioId { get; set; }
       public string Identificacion {get;set;}
        public string Nombre {get;set;}
        public string Apellidos {get;set;}
        public string Direccion {get;set;}
        public string Telefono {get;set;}
         public int MascotaId { get; set; }
    }
}