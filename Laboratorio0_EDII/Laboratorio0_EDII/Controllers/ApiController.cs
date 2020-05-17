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
            MoviesMethods _stack = new MoviesMethods();
            _stack.ReceiveData(NewMovie);
        }
    }
}