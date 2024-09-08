using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleReadLineType
{
    internal class Program
    {
        static ProverkaType proverkaType = new ProverkaType();

        static decimal dm; // 128b
        static double dobl; // 64b
        static long l; // 64b
        static ulong ul; //64b
        static int i; // 32b
        static uint ui; // 32b
        static float f; // 32b
        static short sh; // 16b
        static ushort ush; // 16b
        static byte b; // 8b
        static sbyte sb; //8b

        static void Main(string[] args)
        {
            dm = proverkaType.DecimalType(dm, "Введите decimal => ");
            dobl = proverkaType.DoubleType(dobl, "Введите double => ");
            l = proverkaType.LongType(l, "Введите long => ");
            ul = proverkaType.UlongType(ul, "Введите ulong => ");
            i = proverkaType.IntType(i, "Введите int => ");
            ui = proverkaType.UintType(ui, "Введите uint => ");
            f = proverkaType.FloatType(f, "Введите float => ");
            sh = proverkaType.ShortType(sh, "Введите short => ");
            ush = proverkaType.UshortType(ush, "Введите ushort => ");
            b = proverkaType.ByteType(b, "Введите byte => ");

            Console.WriteLine($"\ndecimal = {dm}\ndouble = {dobl}\nlong = {l}\nulong = {ul}\nint = {i}\nuint = {ui}\nfloat = {f}\nshort = {sh}\nushort = {ush}\nbyte = {b}");

            
            Console.ReadKey();
        }
    }
}
