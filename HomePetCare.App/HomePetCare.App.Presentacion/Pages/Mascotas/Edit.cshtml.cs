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
    public class EditModel : PageModel
    {
        private readonly IRepositorioMascota repositorioMascotas;
        [BindProperty]
        public Mascota Mascota{get;set;}
        public EditModel()
        {
            this.repositorioMascotas = new RepositorioMascota(new HomePetCare.App.Persistencia.AppContext());
        }        
        public IActionResult OnGet()
        {
            if(MascotaId.HashValue)
            {
                Mascota = repositorioMascotas.GetMascota(MascotaId.value);
            }
            else
            {
                Mascota = new Mascota();   //Si no existe la mascota se crea uno nuevo
            }
            if(Mascota == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            {
                return Pages();
            }
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(Mascota.Id>0)
            {
                Mascota = repositorioMascotas.UpdateMascota(Mascota);
            }
            else
            {
                repositorioMascotas.AddMascota(Mascota);
            }
            return Pages();
        }
    }
}

