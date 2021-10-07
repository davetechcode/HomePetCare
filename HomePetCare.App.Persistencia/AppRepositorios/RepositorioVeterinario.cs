using System.Collections.Generic;
using System.Linq;
using HomePetCare.App.Dominio;

namespace HomePetCare.App.Persistencia
{
    public class RepositorioVeterinario : IRepositorioVeterinario
    {   /// <summary>
        /// referencia al contexto de Mascota
        /// </summary>
        private readonly AppContext _appContext;
        /// <summary>
        /// Metodo constructor utiliza
        /// inyeccion de independencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"></param>//
        public RepositorioVeterinario(AppContext appContext)
        {
            _appContext = appContext;
        }
        Veterinario IRepositorioVeterinario.AddVeterinario(Veterinario veterinario)
        {
            var veterinarioAdicionado = _appContext.Veterinarios.Add(veterinario);
            _appContext.SaveChanges();
            return veterinarioAdicionado.Entity;
        }

        void IRepositorioVeterinario.DeleteVeterinario(int VeterinarioId)
        {
            var veterinarioEncontrado = _appContext.Veterinarios.FirstOrDefault(v => v.VeterinarioId == VeterinarioId);
            if (veterinarioEncontrado == null)
                return;
            _appContext.Veterinarios.Remove(veterinarioEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Veterinario> IRepositorioVeterinario.GetAllVeterinarios()
        {
            return _appContext.Veterinarios;
        }

        Veterinario IRepositorioVeterinario.GetVeterinario(int VeterinarioId)
        {
            return _appContext.Veterinarios.FirstOrDefault(v => v.VeterinarioId == VeterinarioId);
        }

        Veterinario IRepositorioVeterinario.UpdateVeterinario(Veterinario veterinario)
        {
            var veterinarioEncontrado = _appContext.Veterinarios.FirstOrDefault(v => v.VeterinarioId == veterinario.VeterinarioId);
            if (veterinarioEncontrado != null)
            {
                veterinarioEncontrado.TarjetaProfesional = veterinario.TarjetaProfesional;
                veterinarioEncontrado.VisitaId = veterinario.VisitaId;
            }
        return veterinarioEncontrado;
        }
    }
}