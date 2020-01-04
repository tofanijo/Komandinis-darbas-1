using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zaidimas1
{
    class Program
    {
        static void Main(string[] args)
        {
            double zemesRutulioPlotas = 0;
            double zemesRutulioTuris = 0;
            double zemesRutulioSpindulys = 6371;
            double trikampioIzambine = 0;
            double statinis1 = 10;
            double statinis2 = 15;




            zemesRutulioPlotas = 4 * Math.PI * Math.Pow(zemesRutulioSpindulys, 2);
            zemesRutulioTuris = (double)((double)4 / (double)3) * Math.PI * Math.Pow(zemesRutulioSpindulys, 3);
            trikampioIzambine = Math.Sqrt(Math.Pow(statinis1, 2) + Math.Pow(statinis2, 2));



            Console.WriteLine("*********************************************");
            Console.WriteLine($"Zemes rutulio turis yra: {zemesRutulioPlotas}");
            Console.WriteLine($"Zemes rutulio turis yra: {zemesRutulioTuris}");
            Console.WriteLine($"Trikampio izambine yra: {trikampioIzambine}");
            Console.WriteLine("*********************************************");

            Console.ReadLine();
        }
    }
}
