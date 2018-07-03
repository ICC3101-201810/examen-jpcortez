using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan_Examen
{[Serializable]
    class Posiciones
    {
        string nombre;
        int puntaje, posicionXpac, posicionYpac, posicionXrojo, posicionYrojo, posicionXrosa, posicionYrosa;

        public Posiciones(string nombre, int puntaje, int posicionXpac, int posicionYpac, int posicionXrojo, int posicionYrojo, int posicionXrosa, int posicionYrosa)
        {
            this.nombre = nombre;
            this.puntaje = puntaje;
            this.posicionXpac = posicionXpac;
            this.posicionYpac = posicionYpac;
            this.posicionXrojo = posicionXrojo;
            this.posicionYrojo = posicionYrojo;
            this.posicionXrosa = posicionXrosa;
            this.posicionYrosa = posicionYrosa;
        }
    }
}
