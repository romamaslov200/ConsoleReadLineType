using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleReadLineType
{
    internal class ProverkaType
    {
        public decimal DecimalType(decimal i, string s)
        {
        start:

            Console.Write(s);
            if (decimal.TryParse(Console.ReadLine().Replace(".", ","), out i))
            {
                return i;
            }
            else
            {
                goto start;
            }
        }

        public double DoubleType(double i, string s)
        {
        start:

            Console.Write(s);
            if (double.TryParse(Console.ReadLine().Replace(".", ","), out i))
            {
                return i;
            }
            else
            {
                goto start;
            }
        }

        public long LongType(long i, string s)
        {
        start:

            Console.Write(s);
            if (long.TryParse(Console.ReadLine(), out i))
            {
                return i;
            }
            else
            {
                goto start;
            }
        }

        public ulong UlongType(ulong i, string s)
        {
        start:

            Console.Write(s);
            if (ulong.TryParse(Console.ReadLine(), out i))
            {
                return i;
            }
            else
            {
                goto start;
            }
        }

        public int IntType(int i, string s)
        {
        start:

            Console.Write(s);
            if (int.TryParse(Console.ReadLine(), out i))
            {
                return i;
            }
            else
            {
                goto start;
            }
        }

        public uint UintType(uint i, string s)
        {
        start:

            Console.Write(s);
            if (uint.TryParse(Console.ReadLine(), out i))
            {
                return i;
            }
            else
            {
                goto start;
            }
        }

        public float FloatType(float i, string s)
        {
        start:

            Console.Write(s);
            if (float.TryParse(Console.ReadLine().Replace(".", ","), out i))
            {
                return i;
            }
            else
            {
                goto start;
            }
        }

        public short ShortType(short i, string s)
        {
        start:

            Console.Write(s);
            if (short.TryParse(Console.ReadLine(), out i))
            {
                return i;
            }
            else
            {
                goto start;
            }
        }

        public ushort UshortType(ushort i, string s)
        {
        start:

            Console.Write(s);
            if (ushort.TryParse(Console.ReadLine(), out i))
            {
                return i;
            }
            else
            {
                goto start;
            }
        }

        public byte ByteType(byte i, string s)
        {
        start:

            Console.Write(s);
            if (byte.TryParse(Console.ReadLine(), out i))
            {
                return i;
            }
            else
            {
                goto start;
            }
        }

        public sbyte SbyteType(sbyte i, string s)
        {
        start:

            Console.Write(s);
            if (sbyte.TryParse(Console.ReadLine(), out i))
            {
                return i;
            }
            else
            {
                goto start;
            }
        }
    }
}
