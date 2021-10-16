using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesMascotas.Models;
using HomePetCare.App.Persistencia;

namespace RazorPagesMascotas.Pages
{
    public class MascotaModel : PageModel
    {
    private readonly IRepositorioMascota repositorioMascota;
     private readonly IRepositorioPropietario repositorioPropietario;
    public IEnumerable<Propietario> Mascota {set; get;}

    [BindProperty]
        public Mascota EntidadMascota {set; get;}

         [BindProperty]
        public Propietario  EntidadPropietario  {set; get;}
        
    public MascotaModel()

    {  
        this.repositorioMascota = new RepositorioMascota(new HomePetCare.App.Persistencia.AppContext());
        this.repositorioPropietario = new RepositorioPropietario(new HomePetCare.App.Persistencia.AppContext());
    }

        public void OnGet(string filtroBusqueda)
        {
            Mascota = repositorioPropietario.GetAllPropietarios();

        }

public  Mascota getUniqueMascota(int idMascota)
{
  return repositorioMascota.GetMascota( idMascota);
   }  

        public ActionResult  OnPost()
        {
         EntidadMascota =  repositorioMascota.AddMascota(EntidadMascota);

         EntidadPropietario.MascotaId=   EntidadMascota.MascotaId;

         Console.WriteLine("capturing new id from dataBase "+ EntidadMascota.MascotaId);

         repositorioPropietario.AddPropietario(EntidadPropietario);

           return RedirectToPage("Mascota");
        }
    }
}
