using System.Collections.Generic;
using RazorPagesMascotas.Models;

namespace HomePetCare.App.Persistencia
{
    public interface IRepositorioPropietario
    {
        // creamos el crud de Propietario
        IEnumerable<Propietario> GetAllPropietarios();
        Propietario UpdatePropietario(Propietario propietario);
        Propietario AddPropietario(Propietario propietario);
        void DeletePropietario(int PropietarioId);
        Propietario GetPropietario(int PropietarioId);
    }

}
