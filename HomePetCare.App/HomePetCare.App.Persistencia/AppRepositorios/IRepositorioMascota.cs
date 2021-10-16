using System.Collections.Generic;
using RazorPagesMascotas.Models;


namespace HomePetCare.App.Persistencia
{
    public interface IRepositorioMascota
    {
        // creamos el crud de Mascota
        IEnumerable<Mascota> GetAllMascotas();
        Mascota AddMascota(Mascota mascota);
        Mascota UpdateMascota(Mascota mascota);
        void DeleteMascota(int MascotaId);
        Mascota GetMascota(int MascotaId);
    }
}