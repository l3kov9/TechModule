namespace _10.DataOverflow
{
    using System;
    public class DataOverflow
    {
        public static void Main()
        {
            ulong maxByte = byte.MaxValue;
            ulong maxUShort = ushort.MaxValue;
            ulong maxUInt = uint.MaxValue;
            ulong maxULong = ulong.MaxValue;

            ulong a = ulong.Parse(Console.ReadLine());
            ulong b = ulong.Parse(Console.ReadLine());
            ulong biggerNum = Math.Max(a, b);
            string biggerType = TypeOfTheNum(biggerNum,maxByte,maxUShort,maxUInt,maxULong);
            ulong smallerNum = Math.Min(a, b);
            string smallerType = TypeOfTheNum(smallerNum, maxByte, maxUShort, maxUInt, maxULong);
            ulong maxSmallerNum = MaxTypeNum(smallerNum, maxByte, maxUShort, maxUInt, maxULong);

            Console.WriteLine("bigger type: "+biggerType);
            Console.WriteLine("smaller type: "+smallerType);
            Console.WriteLine("{0} can overflow {1} {2} times", biggerNum, smallerType, Math.Round(biggerNum/(double)maxSmallerNum)) ;
        }

        private static ulong MaxTypeNum(ulong x, ulong maxByte, ulong maxUShort, ulong maxUInt, ulong maxULong)
        {
            if (x <= maxByte)
            {
                x = maxByte;
                return x;
            }
            else if (x <= maxUShort)
            {
                x = maxUShort;
                return x;
            }
            else if (x <= maxUInt)
            {
                x = maxUInt;
                return x;
            }
            else
            {
                x = maxULong;
                return x;
            }
    }

        private static string TypeOfTheNum(ulong num, ulong maxByte, ulong maxUShort, ulong maxUInt, ulong maxULong)
        {
            if (num <= maxByte)
            {
                return "byte";
            }
            else if (num <= maxUShort)
            {
                return "ushort";
            }
            else if (num <= maxUInt)
            {
                return "uint";
            }
            else
            {
                return "ulong";
            }

        }
    }
}
