using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace campeon.Campeon
{
    class Equipo
    {
        private int _id;
        private string _nombre;
        private string _entrenador;
        private string _comunidad;

        //enlace con jugador 
        private List<Jugador> jugadores = new List<Jugador>();

        public int Id { get; set; } 
        public string Nombre { get; set; }
        public string Entrenador { get; set; }
        public string Comunidad { get; set; }

    }
}
