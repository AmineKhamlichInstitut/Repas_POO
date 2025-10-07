using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repas_POO_1
{
    internal class Equips
    {
        private string _nom;
        private string _esport;
        private List<Jugadors> _jugadors;

        public string Nom 
        {  
            get { return _nom; } 
            set { _nom = value; }
        }
        public string Esport
        {
            get { return _esport; }
            set { _esport = value; }
        }
        public List<Jugadors> Jugadors
        {
            get { return _jugadors; }
            set { _jugadors = value; }
        }
        public Equips()
        {
            _nom = string.Empty;
            _esport = string.Empty;
            Jugadors = new List<Jugadors>();
        }
        public Equips(string nom, string esport)
        {
            this.Nom = nom;
            this.Esport = esport;
            Jugadors = new List<Jugadors>();
        }
        public void AfegirJugador(Jugadors jugador)
        {
            Jugadors.Add(jugador);
        }
        public void LlistarJugadors()
        {
            Console.WriteLine($"Jugadors de l'equip {Nom} ({Esport}):");
            foreach (var jugador in Jugadors)
            {
                Console.WriteLine($"{jugador.MostrarJugadors()}");
            }
        }
    }
}
