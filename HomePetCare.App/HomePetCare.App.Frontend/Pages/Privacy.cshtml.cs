using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using RazorPagesMascotas.Models;
using HomePetCare.App.Persistencia;

namespace HomePetCare.App.Frontend.Pages
{
    public class PrivacyModel : PageModel
    {
         private readonly IRepositorioMascota repositorioMascota;
         private readonly IRepositorioPropietario repositorioPropietario;


        public PrivacyModel()
        {
        this.repositorioMascota = new RepositorioMascota(new HomePetCare.App.Persistencia.AppContext());
        this.repositorioPropietario = new RepositorioPropietario(new HomePetCare.App.Persistencia.AppContext());
        }

        public ActionResult OnGet(int PropietarioId)
        {
            Console.WriteLine("Esto es lo que recibo del get  "+PropietarioId);
            Propietario propietario =repositorioPropietario.GetPropietario(PropietarioId);
            repositorioPropietario.DeletePropietario(PropietarioId);
            repositorioMascota.DeleteMascota(propietario.MascotaId);

            return RedirectToPage("Mascota"); 
        }
    }
}
