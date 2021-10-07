using System.Collections.Generic;
using HomePetCare.App.Dominio;

namespace HomePetCare.App.Persistencia
{
    public interface IRepositorioVisita
    {
        // creamos el crud de Visita
        IEnumerable<Visita> GetAllVisitas();
        Visita GetVisita(int VisitaId);
        Visita Update(Visita visita);
        void DeleteVisita(int VisitaId);
        Visita AddVisita(Visita visita);

    }

}