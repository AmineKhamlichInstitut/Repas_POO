using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioEmpreserialMaquineVehicle
{
    internal class Maquina
    {
        private string _nom;
        private int _id;
        private bool _reservada;
        private string _produccioTipus;
        public Maquina() 
        {
            _nom = string.Empty;
            _id = 0;
            _reservada = false;
            _produccioTipus = string.Empty;
        }

        public Maquina(string nom, int id, bool reservada, string produccioTipus)
        {
            _nom = nom;
            _id = id;
            _reservada = reservada;
            _produccioTipus = produccioTipus;
        }


    }
}
