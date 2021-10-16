using System;
using System.Collections.Generic;

namespace RazorPagesMascotas.Models
{
    public class Mascota
    {
    public int MascotaId { get; set; }
    public string Nombre { get; set; }

    public Propietario Propietario { get; set; }

    }
}