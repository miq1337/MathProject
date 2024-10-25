/* GPL licence
 * Simple script to generate a lot of prime numbers
 * After calculations check 'list'
 * Created by MIQ1337
 * 2024
 */
using System;
using System.Collections.Generic;

namespace MathProject
{
    static class PrimeNumbersGenerator
    {
        static List<uint> list;
        public static void Start()
        {
            list = new List<uint>();

            for (uint i = 2; i < 1000; i++)
                Fun(i);
            Console.WriteLine("Done");//set debug stop flag or handle
        }
        static void Fun(uint v)
        {
            uint ret = MainTask(v);
            if(ret != 0)
                list.Add(ret);
        }
        static uint MainTask(uint num)
        {
            if (num == 0)
                return 0;
            uint model = num;
            int index = 0;
            while (true)
            {
                if (model == 1)
                    break;
                if (index == list.Count)
                    return model;
                if (model % list[index] == 0)
                    model /= list[index];
                else
                    index++;
            }
            return 0;
        }
    }
}
