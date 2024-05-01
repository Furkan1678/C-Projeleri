using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vkinesne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double boy, ike,ikk;
            Console.Write("Boyunuzu Giriniz(m):");
            boy = Convert.ToDouble(Console.ReadLine());
            boy = boy * 100;
            Console.Write("Cinsiyetiniz [1-Erkek 2-Kadın]: ");
            int sec = Convert.ToInt32(Console.ReadLine());
            switch (sec)
            {
                case 1:
                    {
                        ike = 50 + 2.3 * (boy / 2.54 - 60);
                        Console.Write("İdeal Kilonuz (kg): {0:F2}", ike);
                        break;
                    }
                case 2:
                    {
                        ikk = 45 + 2.3 * (boy / 2.54 - 60);
                        Console.Write("İdeal Kilonuz (kg): {0:F2}", ikk);
                        break;
                    }
 }
               
           
             Console.ReadLine();    
        }
    }
}