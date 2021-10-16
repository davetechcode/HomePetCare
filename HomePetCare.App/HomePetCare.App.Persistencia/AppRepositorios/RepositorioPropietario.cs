using System.Collections.Generic;
using System;
using System.Linq;
using RazorPagesMascotas.Models;

namespace HomePetCare.App.Persistencia
{
    public class RepositorioPropietario : IRepositorioPropietario
    {   /// <summary>
        /// referencia al contexto de Mascota
        /// </summary>
        private readonly AppContext _appContext;
        /// <summary>
        /// Metodo constructor utiliza
        /// inyeccion de independencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"></param>//
        public RepositorioPropietario(AppContext appContext)
        {//
            _appContext = appContext; 
        }
        Propietario IRepositorioPropietario.AddPropietario(Propietario propietario)
        {
            var propietarioAdicionado = _appContext.Propietarios.Add(propietario);
            _appContext.SaveChanges();
            return propietarioAdicionado.Entity;
        }

        void IRepositorioPropietario.DeletePropietario(int PropietarioId)
        {
            var propietarioEncontrado = _appContext.Propietarios.FirstOrDefault(pr => pr.PropietarioId == PropietarioId);
            if (propietarioEncontrado == null)
                return;
            _appContext.Propietarios.Remove(propietarioEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Propietario> IRepositorioPropietario.GetAllPropietarios()
        {
            return _appContext.Propietarios;
        }

        Propietario IRepositorioPropietario.GetPropietario(int PropietarioId)
        {
            return _appContext.Propietarios.FirstOrDefault(pr => pr.PropietarioId == PropietarioId);
        }

        Propietario IRepositorioPropietario.UpdatePropietario(Propietario propietario)
        {
             Console.WriteLine("pass object "+propietario.PropietarioId);
            var propietarioEncontrado = _appContext.Propietarios.FirstOrDefault(pr => pr.PropietarioId == propietario.PropietarioId);
        Console.WriteLine("call method  "+propietarioEncontrado.Apellidos);
            if (propietarioEncontrado != null)
            {
                 Console.WriteLine("Hello.. inside method   "+propietarioEncontrado.Apellidos);
               propietarioEncontrado.Apellidos= propietario.Apellidos;
               propietarioEncontrado.Identificacion = propietario.Identificacion;
               propietarioEncontrado.Nombre = propietario.Nombre;
               propietarioEncontrado.Direccion= propietario.Direccion;
               propietarioEncontrado.Telefono= propietario.Telefono;
                _appContext.SaveChanges();

            }
            return propietarioEncontrado;
        }
    }
}