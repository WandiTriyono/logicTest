using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace TestVisual
{
    class Program
    {
        public static List<string> termsList = new List<string>();
       
        // private static void Swap(ref char a, ref char b)
        // {
        //     if (a == b) return;
            

        //     var temp = a;
        //     a = b;
        //     b = temp;
        // }

        // public static void GetPer(char[] list)
        // {
        //     int x = list.Length - 1;
        //     GetPer(list, 0, x); 
        //     Output();
        // }

        // private static void GetPer(char[] list, int k, int m)
        // {
        //     if (k == m)
        //     {
        //         string x = new string(list);
                
        //         //Console.WriteLine("Possible Order: "+x);

        //         Ordering(x);
        //     }
        //     else
        //     {
        //         for (int i = k; i <= m; i++)
        //         {
        //             Swap(ref list[k], ref list[i]);
        //             GetPer(list, k + 1, m);
        //             Swap(ref list[k], ref list[i]);
        //         }
        //     }
        // }

        // private static void Ordering(string listA)
        // {
        //     termsList.Add(listA);
        // }

        // private static void Output()
        // {
        //     //termsList.Sort();
        //     termsList.OrderBy(x => x).ThenBy(x => x.Length);
        //     Console.WriteLine("First Lexi: "+termsList[0]);
        //     //Console.WriteLine("Boom : "+ x);
        // }

        static void Main(string[] args)
        {
            Console.WriteLine("Input String: ");
            string input = Console.ReadLine();
            RemoveLine(input);
            Lexicographical(input);
        }

        private static void RemoveLine(string input)
        {
            string result = string.Empty;
            for(int i =0; i< input.Length;i++)
            {
                if(!result.Contains(input[i]))
                {
                    result += input[i];
                }
            }
            Console.WriteLine("First Occurence: "+result);
        }

        private static void Lexicographical(string input)
        {
            StringBuilder result = new StringBuilder();
            for(int i =0; i< input.Length;i++)
            {
                if(!result.ToString().Contains(input[i]))
                {
                    result.Append(input[i]);   
                }
                else
                {
                    int index = result.ToString().IndexOf(input[i]);
                    if(index +1 <result.Length && result[index +1] < input[i])
                    {
                        result.Remove(index,1);
                        result.Append(input[i]);   
                    }
                }
            }
            Console.WriteLine("Lexicographical: "+result);
        }
    }
}

