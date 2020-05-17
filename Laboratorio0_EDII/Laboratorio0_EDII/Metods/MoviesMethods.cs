using Laboratorio0_EDII.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio0_EDII.Metods
{
    public class MoviesMethods
    {
        public static Stack<Movie> StackMovies = new Stack<Movie>();
        int count = 0;
        public void ReceiveData(Movie NewMovie) {
            count++;
            StackMovies.Push(NewMovie);
        }

    }
}
