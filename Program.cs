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
            dm = proverkaType.Type<decimal>("Введите decimal => ");
            dobl = proverkaType.Type<double>("Введите double => ");
            l = proverkaType.Type<long>("Введите long => ");
            ul = proverkaType.Type<ulong>("Введите ulong => ");
            i = proverkaType.Type<int>("Введите int => ");
            ui = proverkaType.Type<uint>("Введите uint => ");
            f = proverkaType.Type<float>("Введите float => ");
            sh = proverkaType.Type<short>("Введите short => ");
            ush = proverkaType.Type<ushort>("Введите ushort => ");
            b = proverkaType.Type<byte>("Введите byte => ");
            sb = proverkaType.Type<sbyte>("Введите sbyte => ");

            Console.WriteLine($"\ndecimal = {dm}\ndouble = {dobl}\nlong = {l}\nulong = {ul}\nint = {i}\nuint = {ui}\nfloat = {f}\nshort = {sh}\nushort = {ush}\nbyte = {b}\nsbyte = {sb}");

            Console.WriteLine($"\nint + float = {i + f}");
            Console.WriteLine($"double + float = {dobl + f}");
            Console.WriteLine($"int + long = {i + l}");
            Console.WriteLine($"byte + sbyte = {b + sb}");
            Console.WriteLine($"short + ushort = {sh + ush}");

            Console.ReadKey();
        }
    }
}
