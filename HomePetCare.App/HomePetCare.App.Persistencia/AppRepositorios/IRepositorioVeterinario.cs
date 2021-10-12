using System.Collections.Generic;
using HomePetCare.App.Dominio;

namespace HomePetCare.App.Persistencia
{
    public interface IRepositorioVeterinario
    {
        // creamos el crud de Veterinario
        IEnumerable<Veterinario> GetAllVeterinarios();
        Veterinario GetVeterinario(int VeterinarioId);
        Veterinario UpdateVeterinario(Veterinario veterinario);
        void DeleteVeterinario(int VeterinarioId);
        Veterinario AddVeterinario(Veterinario veterinario);
    }

}