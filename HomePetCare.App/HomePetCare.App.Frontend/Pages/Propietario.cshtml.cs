using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesMascotas.Models;
using HomePetCare.App.Persistencia;

namespace RazorPagesPropietario.Pages
{

    public class PropietarioModel : PageModel
    {
        private readonly IRepositorioPropietario repositorioPropietario;

        [BindProperty]
        public Propietario EntidadPropietario { set; get; }
        public PropietarioModel()
        {
            this.repositorioPropietario = new RepositorioPropietario(new HomePetCare.App.Persistencia.AppContext());

        }
        public void OnGet(int PropietarioId)
        {
            EntidadPropietario = repositorioPropietario.GetPropietario(PropietarioId);
        }
        public ActionResult OnPost()
        {
            Console.WriteLine("Hello.. Nuevo apellido "+EntidadPropietario.Apellidos);
            repositorioPropietario.UpdatePropietario(EntidadPropietario);
            return RedirectToPage("Mascota");
        }
    }
}
