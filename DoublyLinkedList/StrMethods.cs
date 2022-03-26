using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    static public class StrMethods
    {
        static public string RandomStr(int min, int max)
        {
            string result = "";
            int rnd = new Random().Next(min, max);
            for (int i = 0; i < rnd; i++)
                result += NumberToAZ();
            return result;

        }

        static public char NumberToAZ()
        {
            string symbols = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int rnd = new Random().Next(symbols.Length);

            return symbols[rnd];
        }
    }
}
