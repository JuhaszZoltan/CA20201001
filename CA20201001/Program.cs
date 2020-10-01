using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CA20201001
{
    class Program
    {
        static Random rnd = new Random();
        static void Main()
        {
            int[] t = new int[20];
            float k = 10F;
            float v = 15F;
            for (int i = 0; i < t.Length; i++)
            {
                t[i] =  rnd.Next((int)k, (int)v);
                Console.WriteLine(
                    "{0,2}.it: [{1}  - {2,3}): {3} ",
                    i + 1, (int)k, (int)v, t[i]);
                k += 4.5F;
                v += 4.5F;
            }
            Console.ReadKey();
        }
    }
}
