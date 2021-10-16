using System.Collections.Generic;
using System.Linq;
using RazorPagesMascotas.Models;

namespace HomePetCare.App.Persistencia
{
    public class RepositorioPersona : IRepositorioPersona
    {   /// <summary>
        /// referencia al contexto de Mascota
        /// </summary>
        private readonly AppContext _appContext;
        /// <summary>
        /// Metodo constructor utiliza
        /// inyeccion de independencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"></param>//
        public RepositorioPersona(AppContext appContext)
        {
            _appContext = appContext;
        }
        Persona IRepositorioPersona.AddPersona(Persona persona)
        {
            var personaAdicionada = _appContext.Personas.Add(persona);
            _appContext.SaveChanges();
            return personaAdicionada.Entity;
        }

        void IRepositorioPersona.DeletePersona(int Id)
        {
            var personaEncontrada = _appContext.Personas.FirstOrDefault(p => p.Id==Id);
            if(personaEncontrada == null)
               return;
            _appContext.Personas.Remove(personaEncontrada);
            _appContext.SaveChanges();  
        }

        IEnumerable<Persona> IRepositorioPersona.GetAllPersonas()
        {
            return _appContext.Personas;
        }

        Persona IRepositorioPersona.GetPersona(int Id)
        {
            return _appContext.Personas.FirstOrDefault(p => p.Id==Id);
        }

        Persona IRepositorioPersona.UpdatePersona(Persona persona)
        {
            var personaEncontrada = _appContext.Personas.FirstOrDefault(p => p.Id==persona.Id);
            if(personaEncontrada == null)
            {
                personaEncontrada.Identificacion = persona.Identificacion;
                personaEncontrada.Nombre = persona.Nombre;
                personaEncontrada.Apellidos = persona.Apellidos;
                personaEncontrada.Direccion = persona.Direccion;
                personaEncontrada.Telefono = persona.Telefono;

                _appContext.SaveChanges();
                
            }
            return personaEncontrada;
        }
    }
}