using System.Xml.Schema;
using System.Collections.Generic;
using System.Linq;
using RazorPagesMascotas.Models;

namespace HomePetCare.App.Persistencia
{
    public class RepositorioVisita : IRepositorioVisita
    {   /// <summary>
        /// referencia al contexto de Mascota
        /// </summary>
        private readonly AppContext _appContext;
        /// <summary>
        /// Metodo constructor utiliza
        /// inyeccion de independencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"></param>//
        public RepositorioVisita(AppContext appContext)
        {
            _appContext = appContext;
        }
        Visita IRepositorioVisita.AddVisita(Visita visita)
        {
            var visitaAdicionada = _appContext.Visita.Add(visita);
            _appContext.SaveChanges();
            return visitaAdicionada.Entity;
        }

        void IRepositorioVisita.DeleteVisita(int VisitaId)
        {
            var visitaEncontrada = _appContext.Visita.FirstOrDefault(vi => vi.VisitaId == VisitaId);
            if (visitaEncontrada == null)
                return;
            _appContext.Visita.Remove(visitaEncontrada);
            _appContext.SaveChanges();
        }

        IEnumerable<Visita> IRepositorioVisita.GetAllVisitas()
        {
            return _appContext.Visita;
        }

        Visita IRepositorioVisita.GetVisita(int VisitaId)
        {
            return _appContext.Visita.FirstOrDefault(vi => vi.VisitaId == VisitaId);
        }

        Visita IRepositorioVisita.Update(Visita visita)
        {
            var visitaEncontrada = _appContext.Visita.FirstOrDefault(vi => vi.VisitaId == visita.VisitaId);
            if (visitaEncontrada != null)
            {
                visitaEncontrada.Temperatura = visita.Temperatura;
                visitaEncontrada.Peso = visita.Peso;
                visitaEncontrada.FrecuenciaRespiratoria = visita.FrecuenciaRespiratoria;
                visitaEncontrada.FrecuenciaCardiaca = visita.FrecuenciaCardiaca;
                visitaEncontrada.EstadoAnimo = visita.EstadoAnimo;
                visitaEncontrada.FechaVisita = visita.FechaVisita;
                visitaEncontrada.Raza = visita.Raza;
                visitaEncontrada.Genero = visita.Genero;
                visitaEncontrada.MascotaId = visita.MascotaId;
                visitaEncontrada.VeterinarioId = visita.VeterinarioId;

                _appContext.SaveChanges(); 
            }
            return visitaEncontrada;

        }
    }
}