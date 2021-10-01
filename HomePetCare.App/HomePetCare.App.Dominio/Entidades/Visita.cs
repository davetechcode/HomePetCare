using System;

namespace HomePetCare.App.Dominio
{
    public class Visita
    {
        public int IDVisita { get; set; }
        public float Temperatura { get; set;}
        public string Peso { get; set; }
        public string FrecuenciaRespiratoria { get; set;}
        public string FrecuenciaCardiaca { get; set;}
        public string EstadoAnimo { get; set; }
        public DateTime FechaVisita { get; set; }
        public string Raza { get; set; }
        public Genero Genero { set; get; }
       // public int IdMascota { get; set;}
       // public int IdVeterinario { get; set; } 
    }
}