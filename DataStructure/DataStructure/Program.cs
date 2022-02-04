using System;
using System.Collections.Generic;

namespace DataStructure
{
    public class Program
    {
        public static int[] ArrayArray = new int[5] {12, 34, 51, 5, 9};
        public static void Main(string[] args)
        {
            while (true)
            {
                
                Console.Clear();
                Console.WriteLine(ArrayArray.Length);
                Console.WriteLine("\n\tWelcome to Data Structures and Algorithms " +
                                  "\n\t[1]Array\n\t[2]Linked List" +
                                  "\n\t[3]Delete log " + "\n\t[4]Edit log" +
                                  "\n\t[5]Sort Logs" + "\n\t[6]Search logs" +
                                  "\n\t[7]End program");

                Int32.TryParse(Console.ReadLine(), out int hello);
                // Menu

                switch (hello)
                {
                    case 1:
                        ArrayDataStruct arrtest = new ArrayDataStruct();
                        arrtest.Main();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    default:
                        break;
                }
            }
        }
    }
}