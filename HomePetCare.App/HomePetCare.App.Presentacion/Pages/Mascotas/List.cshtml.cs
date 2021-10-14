using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HomePetCare.App.Dominio;
using HomePetCare.App.Persistencia;

namespace HomePetCare.App.Frontend.Pages
{
    public class MascotaModel : PageModel
    {
        private readonly IRepositorioMascota repositorioMascota;
        public IEnumerable<Mascota> Mascota {set; get;}
        public ListModel()
    {
        this.repositorioMascota = new RepositorioMascota(new HomePetCare.App.Persistencia.AppContext());
    }

        public void OnGet(string filtroBusqueda)
        {
           Mascotas = respositorioMascota.GetAllMascotas();
        }
    }
}
