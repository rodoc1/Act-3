using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace campeon.Campeon
{
    class Jugador : Persona
    {

        private int _num;
        private string _posicion;

        //enlace con la cclase equipo 
        private Equipo _equipe;

        public int Num { get; set; }
        public string Posicion { get; set; }
        public Equipo Equipo { get; set; }
    }
}
