using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace donguToplamiki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //0-N arası tek ve çift tam sayıların toplamı
            float toplamcift = 0, toplamtek = 0, toplam;
            Console.WriteLine("Lutfen ust siniri giriniz: ");
            int sinir=Convert.ToInt32(Console.ReadLine());
            
      
            
                for(int i = 1; i <= sinir; i++)
                {
                    if (i % 2 == 1)
                    {
                         toplamtek=toplamtek + i;
                    }
                    else if(i %2 ==0)
                {
                    toplamcift=toplamcift+ i;
                }
                }
                toplam = toplamtek+toplamcift;
            Console.WriteLine("Toplam tek: {0}", toplamtek);
            Console.WriteLine("Toplam çift: {0}", toplamcift);
            Console.WriteLine("Toplam tek+çift: {0}", toplam);
            Console.ReadLine();


        }
    }
    }
