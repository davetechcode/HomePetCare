using System.Collections.Generic;
using HomePetCare.App.Dominio;


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