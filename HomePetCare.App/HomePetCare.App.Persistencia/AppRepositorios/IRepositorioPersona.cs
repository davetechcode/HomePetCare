using System.Collections.Generic;
using RazorPagesMascotas.Models;

namespace HomePetCare.App.Persistencia
{
    public interface IRepositorioPersona
    {
        // creamos el crud de persona
        IEnumerable<Persona> GetAllPersonas();
        Persona AddPersona(Persona persona);
        Persona UpdatePersona(Persona persona);
        void DeletePersona (int Id);
        Persona GetPersona(int Id);
    }
}



