using System;

namespace RazorPagesMascotas.Models
{
    public class Visita
    {
        public int VisitaId { get; set; }
        public float Temperatura { get; set;}
        public string Peso { get; set; }
        public string FrecuenciaRespiratoria { get; set;}
        public string FrecuenciaCardiaca { get; set;}
        public string EstadoAnimo { get; set; }
        public DateTime FechaVisita { get; set; }
        public string Raza { get; set; }
        public Genero Genero { set; get; }
        public int MascotaId { get; set;}
        public int VeterinarioId { get; set; } 
    }
}