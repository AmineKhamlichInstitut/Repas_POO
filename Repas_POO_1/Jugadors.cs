using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace Repas_POO_1
{
    internal class Jugadors
    {
        private string _nomJugador;
        private int _dorsal;
        private int _edat;

        public string NomJugador
        {
            get { return _nomJugador; }
            set { _nomJugador = value; } 
        }

        public int Dorsal
        {
            get { return _dorsal; }
            set { _dorsal = value; }
        }
        public int Edat
        {
            get { return _edat; }
            set { _edat = value; }
        }
        public Jugadors()
        {
            _nomJugador = "Sense Nom";
            _dorsal = 0;
            _edat = 0;
        }

        public Jugadors(string nom, int dorsal, int edat)
        {
            this.NomJugador = nom;
            this.Dorsal = dorsal;
            this.Edat = edat;
        }
        public string MostrarJugadors()
        {
            return $"Nom: {NomJugador}, Dorsal: {Dorsal}, Edat: {Edat}";
        }
    }
}
