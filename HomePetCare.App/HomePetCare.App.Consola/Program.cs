using System.IO.Pipes;
using System.Xml.Xsl;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System;
using HomePetCare.App.Dominio;
using HomePetCare.App.Persistencia;

namespace HomePetCare.App.Consola
{
    class Program
    {
        private static IRepositorioMascota _repoMascota = new RepositorioMascota(new Persistencia.AppContext());
        private static IRepositorioPersona _repoPersona = new RepositorioPersona(new Persistencia.AppContext());
        private static IRepositorioPropietario _repoPropietario = new RepositorioPropietario(new Persistencia.AppContext());
        private static IRepositorioVeterinario _repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());
        private static IRepositorioVisita _repoVisita = new RepositorioVisita(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World...... \n¡this is a Veterinary at Home!\n\t by 'Team 5 coders'\n");
            //AddPersona();
            //AddMascota();
            //AddVeterinario();
            //AddPropietario();
            //AddVisita();
            BuscarMascota(1);
            BuscarPersona(1);
            BuscarPropietario(1);
            BuscarVeterinario(1);
            BuscarVisita(1);
        }
// =====================================================================================================================================
//                                                      implementacion de creaciones

        private static void AddMascota()
        { 
            var mascota = new Mascota{
                Nombre = "doggy"                

            };
            _repoMascota.AddMascota(mascota);
        }
        private static void AddPersona()
        {
            var persona = new Persona{
                Identificacion = "123456789",
                Nombre = "Franciso",
                Apellidos = "Garcia",
                Direccion = "av. siempre viva",
                Telefono = "9874561"

            };
            _repoPersona.AddPersona(persona);
        }
        private static void AddPropietario()
        {
            var propietario = new Propietario{

            };
            _repoPropietario.AddPropietario(propietario);
        }
        private static void AddVeterinario()
        {
            var veterinario = new Veterinario{
                TarjetaProfesional = "MVI-123456"

            };
            _repoVeterinario.AddVeterinario(veterinario);
        }
        private static void AddVisita()
        {
            var  visita = new Visita{
                Temperatura = 38,
                Peso = "28.3",
                FrecuenciaRespiratoria = "25",
                FrecuenciaCardiaca = "70",
                EstadoAnimo = "tranquilo",
                Genero = Genero.Hembra,
                FechaVisita = new DateTime(2021, 02, 28),
                Raza = "Labrador"
            };
            _repoVisita.AddVisita(visita);
        }
// =====================================================================================================================================
//                                                        implementacion de busquedas

        private static void BuscarMascota(int MascotaId)
        {
            var mascota =_repoMascota.GetMascota(MascotaId);
            Console.WriteLine("ingreso a buscar mascota de nombre:"+" "+"**"+mascota.Nombre+"**\n");
        }

        private static void BuscarPersona(int Id)
        {
            var persona =_repoPersona.GetPersona(Id);
            Console.WriteLine("ingreso a buscar persona de nombre:"+" "+"**"+persona.Nombre+" "+persona.Apellidos+"**\n");
        }

        private static void BuscarPropietario(int PropietarioId)
        {
            var propietario =_repoPropietario.GetPropietario(PropietarioId);
            Console.WriteLine("ingreso a buscar propietario de Id:"+" "+"**"+propietario.PropietarioId+"**\n");
        }

        private static void BuscarVeterinario(int VeterinarioId)
        {
            var veterinario =_repoVeterinario.GetVeterinario(VeterinarioId);
            Console.WriteLine("ingreso a buscar veterinario de TarjetaProfesional numero:"+" "+"**"+veterinario.TarjetaProfesional+"**\n");
        }

        private static void BuscarVisita(int VisitaId)
        {
            var visita =_repoVisita.GetVisita(VisitaId);
            Console.WriteLine("ingreso a buscar Visita con los siguientes datos:\n\t"+
                                "Temperatura :"+" "+visita.Temperatura+"\n\t"+
                                "Peso:"+" "+visita.Peso+"\n\t"+
                                "FrecuenciaRespiratoria :"+" "+visita.FrecuenciaRespiratoria+"\n\t"+
                                "FrecuenciaCardiaca :"+" "+visita.FrecuenciaCardiaca+"\n\t"+
                                "EstadoAnimo :"+" "+visita.EstadoAnimo+"\n\t"+
                                "Genero :"+" "+visita.Genero+"\n\t"+ 
                                "FechaVisita :"+" "+visita.FechaVisita+"\n\t"+
                                "Raza :"+" "+visita.Raza+"\n\t"                         
                                
                                );
        }

        
    }
}
