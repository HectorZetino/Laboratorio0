using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Laboratorio0_EDII.Metods;
using Laboratorio0_EDII.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorio0_EDII.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ApiController : ControllerBase

    {    /// <summary>
         /// Metodo para recibir las peliculas que ingrese el usuario
         /// </summary>
         /// <param name="NewMovie">Nueva pelicula ingresada</param>
        [HttpPost]
        public void PostMovies([FromForm]Movie NewMovie) {
            MoviesMethods _Queue = new MoviesMethods();
            _Queue.ReceiveData(NewMovie);
        }
        /// <summary>
        /// Metodo que devulve la lista de datos almacenada
        /// </summary>
        [HttpGet]
        public List<Movie> GetMovies() {
            MoviesMethods _ListReturn = new MoviesMethods();
            return _ListReturn.ReturnData().ToList();
        }
        /// <summary>
        /// Metodo que retorna la lista completa de peliculas ingresadas.
        /// </summary>
        /// <returns>Retorna toda la lista de Movies</returns>
        [HttpGet("Complete_List")]
        public List<Movie> GetCompleteMovies() {
            MoviesMethods _ListComplete = new MoviesMethods();
            return _ListComplete.ReturnCompleteList();
        }
    }
}