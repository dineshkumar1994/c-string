using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        private static int i;
       
        public static void Main()
        {
            String s = "abcABC";
            string temp = s;
            int Count = 1;
            //var chars = s.ToCharArray();
            //Console.WriteLine("Original string: {0}", s);
            //Console.WriteLine("Character array:");
            //for (int ctr = 0; ctr < chars.Length; ctr++)
                //Console.WriteLine("   {0}: {1}", ctr, chars[ctr]);
           // Console.ReadLine();
            Console.WriteLine("The entered string :{0}", s);
            for (int i=0;i<s.Length-1;i++)
            {
               
            string sub = s.Substring(s.Length-1);
            string restStr = s.Substring(0, s.Length-1);
            // string restStr = input.Substring(2); Can also use this instead of above line
            string madeStr = sub + "" + restStr;
            //Console.WriteLine("The entered string :{0}", s);
            Console.WriteLine("The new string :{0}",madeStr);
           // Console.ReadLine();
            s = madeStr;
                if(temp==madeStr)
                {
                    Count++;
                }
            } Console.WriteLine(Count);
            Console.ReadLine();
           
        }
    
    }
}


