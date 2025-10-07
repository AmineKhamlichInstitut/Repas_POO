using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Repas_POO_1
{
    internal class Program
    {
        public static void MostrarMenu()
        {
            Console.WriteLine("0. Sortir");
            Console.WriteLine("1. Gestió lligues");
            Console.WriteLine("2. Gestió equips");
            //Console.WriteLine("3. Gestió jugadors");
            Console.Write("Tria una opció: ");
        }
        
        static void Main(string[] args)
        {
            bool sortir = false;
            bool tornar = false;
            List<Lliga> lligues = new List<Lliga>();

            do
            {
                MostrarMenu();
                int opcio = Convert.ToInt32(Console.ReadLine());

                switch (opcio)
                {
                    case 0:
                        sortir = true;
                        break;
                    case 1:
                        tornar = false;
                        do
                        {
                            Console.WriteLine("0. Tornar");
                            Console.WriteLine("1. Afegir Lliga");
                            Console.WriteLine("2. Mostar equips");
                            int opcioLliga = Convert.ToInt32(Console.ReadLine());

                            switch (opcioLliga)
                            {
                                case 0:
                                    tornar = true;
                                    break;
                                case 1:
                                    tornar = false;
                                    Console.WriteLine("Afegeix nom de la Lliga");
                                    string nomLliga = Console.ReadLine();

                                    bool existeix = false;
                                    int i = 0;
                                    while (!existeix && i < lligues.Count)
                                    {
                                       // if( i < lligues.Count )
                                       // {
                                            // Comparació ignorant majúscules/minúscules d'una manera fàcil d'entendre
                                            if (lligues[i].NomLliga != null &&
                                                lligues[i].NomLliga.ToLower() == nomLliga.ToLower())
                                            {
                                                Console.WriteLine("Ja existeix una lliga amb aquest nom.");
                                                existeix = true;
                                            }
                                       // }
                                        if (!existeix)
                                            i++;
                                    }
                                    //Lliga lligaActual;
                                    Console.WriteLine("Afegeix nom equips de la lliga");
                                    string equipLliga = Console.ReadLine();
                                    Console.WriteLine("Afegeix tipus d'esport");
                                    string esportEquip = Console.ReadLine();
                                    Equips eq = new Equips(equipLliga, esportEquip);

                                    if (existeix)
                                    {
                                        lligues[i].AfegirEquip(eq);
                                    }
                                    else
                                    {
                                        Lliga lg = new Lliga(nomLliga);
                                        lg.AfegirEquip(eq);
                                        lligues.Add(lg);
                                        //lligaActual = lg;
                                    }
                                    //lligues.Remove(lg);
                                    //lligues.RemoveAt(lligues.Count -1);
                                    //lligues.Remove(lligaActual);
                                    break;

                                case 2:
                                    Console.WriteLine("Escriu Nom de la lliga");
                                    nomLliga = Console.ReadLine();

                                    existeix = false;
                                    i = 0;
                                    while (!existeix && i < lligues.Count)
                                    {
                                        //if (i < lligues.Count)
                                        //{
                                            // Comparació ignorant majúscules/minúscules d'una manera fàcil d'entendre
                                            if (lligues[i].NomLliga != null &&
                                                lligues[i].NomLliga.ToLower() == nomLliga.ToLower())
                                            {
                                                //Console.WriteLine("Ja existeix una lliga amb aquest nom.");
                                                lligues[i].LlistarEquips();
                                                existeix = true;
                                            }
                                        //}
                                        if (!existeix)
                                            i++;
                                    }
                                    if (!existeix)
                                        Console.WriteLine("Lliga no existeix");
                                    break;

                                default:
                                    Console.WriteLine("Opció incorrecte");
                                    break;
                            }
                        }while (!tornar);
                        break;

                    case 2:
                        tornar = false;
                        do
                        {
                            Console.WriteLine("0. Tornar");
                            Console.WriteLine("1. Afegir jugador/ Add Player");
                            Console.WriteLine("2. Mostar jugadors de l'equip / View Players of teams");
                            int opcioLliga = Convert.ToInt32(Console.ReadLine());

                            switch (opcioLliga)
                            {
                                case 0:
                                    tornar = true;
                                    break;
                                case 1:
                                    Console.WriteLine("Afegeix Nom de la lliga");
                                    string nomLliga =Console.ReadLine();

                                    bool existeix = false;
                                    bool equipEsisteix = false;
                                    int i = 0, j = 0;
                                    while (!existeix && i < lligues.Count)
                                    {

                                        // Comparació ignorant majúscules/minúscules d'una manera fàcil d'entendre
                                        if (lligues[i].NomLliga != null &&
                                            lligues[i].NomLliga.ToLower() == nomLliga.ToLower())
                                        {
                                            Console.WriteLine("Afegeix Nom de l'equip");
                                            string nomEquip = Console.ReadLine();
                                            while(!equipEsisteix)
                                            {
                                                if (j < lligues[i].Equips.Count)
                                                {
                                                    if (lligues[i].Equips[j].Nom != null &&
                                                        lligues[i].Equips[j].Nom.ToLower() == nomEquip.ToLower())
                                                    {
                                                        Console.WriteLine("Afegeix Nom");
                                                        string nom = Console.ReadLine();
                                                        Console.WriteLine("Afegeix dorsal");
                                                        int dosral = Convert.ToInt32(Console.ReadLine());
                                                        Console.WriteLine("Afegeix edat");
                                                        int edat = int.Parse(Console.ReadLine());
                                                        Jugadors jg = new Jugadors(nom, dosral, edat);
                                                        lligues[i].Equips[j].AfegirJugador(jg);
                                                        equipEsisteix= true;
                                                    }
                                                    if (!equipEsisteix)
                                                        j++;
                                                }
                                            }
                                            existeix = true;
                                        }
                                        if (!existeix)
                                            i++;
                                    }
                                    if (!existeix)
                                        Console.WriteLine("La lliga no existeix");

                                    break;
                                case 2:
                                    Console.WriteLine("Quin equip vols visualitzar");
                                    string nomEquipo = Console.ReadLine();

                                    j = 0;

                                    for(i = 0; i < lligues.Count; i++)
                                    {
                                        for (j = 0; j < lligues[i].Equips.Count; j++)
                                        {
                                            if (lligues[i].Equips[j].Nom != null &&
                                                    lligues[i].Equips[j].Nom.ToLower() == nomEquipo.ToLower())
                                            { 
                                                lligues[i].Equips[j].LlistarJugadors(); 
                                                break; 
                                            }
                                        }
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Opció incorrecte");
                                    break;
                            }
                        } while (!tornar);
                        break;
                    default:
                        Console.WriteLine("Opció incorrecte");
                        break;
                }
            } while (!sortir);

            //// Crear una lliga
            ////Lliga lliga = new Lliga("LFP");
            ////Lliga lliga = new Lliga("LFP");

            //// Crear equips
            //Equips equip1 = new Equips("FC Barcelona", "Futbol");
            //Equips equip2 = new Equips("Real Madrid", "Futbol");

            //// Afegir jugadors a l'equip 1
            //equip1.AfegirJugador(new Jugadors("Lionel Messi", 10, 34));
            //equip1.AfegirJugador(new Jugadors("Xavi Hernandez", 6, 41));

            //// Afegir jugadors a l'equip 2
            //equip2.AfegirJugador(new Jugadors("Cristiano Ronaldo", 7, 36));
            //equip2.AfegirJugador(new Jugadors("Sergio Ramos", 4, 35));

            //// Afegir equips a la lliga
            //lliga.AfegirEquip(equip1);
            //lliga.AfegirEquip(equip2);

            //// Llistar equips de la lliga
            //lliga.LlistarEquips();

            //// Llistar jugadors de cada equip
            //equip1.LlistarJugadors();
            //equip2.LlistarJugadors();
            //Console.ReadLine();
        }
    }
}
