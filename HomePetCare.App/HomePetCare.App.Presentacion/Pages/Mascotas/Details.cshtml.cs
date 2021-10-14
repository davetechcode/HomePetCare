using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HomePetCare.App.Dominio;
using HomePetCare.App.Persistencia;

namespace HomePetCare.App.Presentacion.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioMascota repositorioMascotas;
        //Tiene que ser igual a como está la clase.
        public Mascota Mascota {set;get;}
        public DetailsModel()
        {
            this.repositorioMascota = new repositorioMascotas(new HomePetCare.App.Persistencia.AppContext());
        }
        public IActionResult Onget(int MascotaId)
        {
            Mascota = repositorioMascota.GetMascota(MascotaId);
            if(Mascota == null)
            {
                return RedirectToPage("./Notfound");
            }
            else
            {
                return page();
            }
        }
        public void OnGet()
        {
        }
    }
}
