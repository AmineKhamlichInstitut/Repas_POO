using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repas_POO_1
{
    internal class Lliga
    {
        // Atributs
        private string _nom;
        private List<Equips> _equips;

        // Accessors
        public string NomLliga
        {
            get { return _nom; }
            set { _nom = value; }
        }
        public List<Equips> Equips
        {
            get { return _equips; }
            set { _equips = value; }
        }

        public Lliga()
        {
            _nom = null;
            Equips = new List<Equips>();
        }
        public Lliga(string nom)
        {
            this.NomLliga = nom;
            Equips = new List<Equips>();
        }
        public void AfegirEquip(Equips equip)
        {
            Equips.Add(equip);
        }
        public void LlistarEquips()
        {
            Console.WriteLine($"Equips de la lliga {NomLliga}:");
            foreach (var equip in Equips)
            {
                Console.WriteLine($"- {equip.Nom} ({equip.Esport})");
            }
        }
    }
}
