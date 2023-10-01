using System.IO;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(SonlarQushish(9));
            Console.WriteLine(Kupaytirish(5));
            Console.WriteLine(QurbaqaMAsalasi(12,120));


        }//n -> chivinlar soni
        // kun -> kun necha kundankeyin qurbaqa 100 tadan kup chivin yeydi
        //har kuni 12 chivin + 2 va yangi kuni 20 foiz kup yeydi
        static int QurbaqaMAsalasi(float n, int kun)
        {
            if(n>100)
            {
                return kun;
            }
            else
            {
                return QurbaqaMAsalasi((n + n * 0.20f + 2) , kun+1);
            }

        }
        static int SonlarQushish(int x)//4
        {
            if(x == 1)
            {
                return 1;
            }
            else
            {
                return x + SonlarQushish(x-1);
            }

            //4-> 4+ sonlar(3)
            //3-> 3+ sonlar(2)
            //2-> 2+ sonalar(1)=1// 2+1+
        }
        static int Kupaytirish(int x)
        {
            if(x == 1)
            {
                return 1;
            }
            else
            {
                return x * Kupaytirish(x-1);
            }
        }

        
    }
}