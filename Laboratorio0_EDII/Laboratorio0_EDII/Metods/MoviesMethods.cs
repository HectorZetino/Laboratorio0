using Laboratorio0_EDII.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio0_EDII.Metods
{
    public class MoviesMethods
    {
        public static Queue<Movie> StackMovies = new Queue<Movie>();
        public static List<Movie> ListMovies = new List<Movie>();
        /// <summary>
        /// Metodo para almacenar los valores 
        /// </summary>
        /// <param name="NewMovie"></param>
        public void ReceiveData(Movie NewMovie) {
            StackMovies.Enqueue(NewMovie);
            ListMovies.Add(NewMovie);
        }
        /// <summary>
        /// metodo para retornar los valores
        /// </summary>
        /// <returns>Retorna unicamente los 10 valores de la lista</returns>
        public Queue<Movie> ReturnData() {
            while (StackMovies.Count() > 10)
            {
                StackMovies.Dequeue();
            }
            return StackMovies;
        }
        /// <summary>
        /// Metodo que devuelve todos los datos sin excepcion 
        /// </summary>
        /// <returns></returns>
        public List<Movie> ReturnCompleteList() {
            return ListMovies;
        }

    }
}
