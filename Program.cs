using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pertemuan_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrName = {"Fattaah", "Willy", "Dzaki"};
            string[] arrNim = { "4814", "4822", "4563" };
            int[] arrNilai = { 90, 85, 80 };

            Console.WriteLine("NO      Nim        Name        Nilai");
            Console.WriteLine("-----------------------------------");

            for(int i = 0; i < arrName.Length; i++)
            {
                Console.WriteLine($"{(i + 1).ToString().PadRight(8)} {arrNim[i]} {arrName[i].PadLeft(10)} {arrNilai[i].ToString().PadLeft(11)}");
            }
        }
    }
}
