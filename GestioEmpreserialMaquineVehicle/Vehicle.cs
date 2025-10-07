using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioEmpreserialMaquineVehicle
{
    internal class Vehicle
    {
        private string _matricula;
        private string _marca;
        private string _model;
        private int _preu_vehicle;
        private float _consum;
        private int _peso;
        private string _combustibleTipus;
        private bool _reservat;

        public Vehicle()
        {
            _matricula = "0000 XXX";
            _marca = string.Empty;
            _model = string.Empty;
            _preu_vehicle = 00;
            _consum = 0;
            _peso = 0;
            _combustibleTipus = string.Empty;
            _reservat = false;
        }

        public Vehicle(string matricula, string marca, string model,
            int preu, float consum, int pes, string combustible, bool reservat)
        {
            this._matricula = matricula;
            this._marca = marca;
            this._model = model;
            this._preu_vehicle = preu;
            this._consum = consum;
            this._peso = pes;
            this._combustibleTipus=combustible;
            this._reservat = reservat;
        }

        public string Matricula
        {   get { return _matricula; } set { _matricula = value; } }

        public string Marca
            { get { return _marca; } set { _marca = value; } }

        public string Model
            { get { return _model; } set { this._model = value; } }

        public int Preu
            { get {return _preu_vehicle} set { _preu_vehicle = value; } }

        public float Consum
            { get { return _consum; } set {_consum = value; } }

        public int Pes
            { get { return _peso; } set { _peso = value; } }

        public string CombustibleTipus
            { get { return _combustibleTipus; } set { _combustibleTipus = value; } }

        public bool Reservat
            { get { return _reservat; } set {_reservat = value; } }

    }
}
