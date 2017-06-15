using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication100
{

    class Program
    {
        static void Main()
        {
            int count1 = 0;
            int count2 = 0;
            TimeSpan span1 = new TimeSpan(23, 23, 23);
            Console.WriteLine(span1);
            // span1.Duration().Hours > 0 ? string.Format("{0:0} hour{1}, ", span.Hours, span.Hours == 23 ? String.Empty : "s") : string.Empty,
            string formattedTimeSpan1 = string.Format("{0:D2}{1:D2}{2:D2} ", span1.Hours, span1.Minutes, span1.Seconds);
            Console.WriteLine(formattedTimeSpan1);
            TimeSpan span2 = new TimeSpan(11, 11, 11);
            Console.WriteLine(span2);
            string formattedTime = string.Format("{0:D2}{1:D2}{2:D2} ", span2.Hours, span2.Minutes, span2.Seconds);
            Console.WriteLine(formattedTime);

            int a = Convert.ToInt32(formattedTime);
            int b = Convert.ToInt32(formattedTimeSpan1);
            Console.WriteLine("a={0}",a);
            Console.WriteLine("b={0}", b);
            int[] ara = Program.intToArray(a);
            int[] ara1 = Program.intToArray(b);
            for (int i = 0; i < ara.Length; i++)
            {
                Console.WriteLine("a[{0}]={1}", i, ara[i]);
            }
            for (int i = 0; i < ara1.Length; i++)
            {
                Console.WriteLine("b[{0}]={1}", i, ara1[i]);
            }
            {
                for (int i = 2;i < ara.Length; i++)
                    
                {
                   if( ara[0] == ara[i])

                   { count1++; }

                       if (ara[1] == ara[i])
                       {
                           count2++;

                       }
                   }
                if (count1 + count2 == 8 || count1+ count2==4) 
                {
                    Console.WriteLine("No of interesting points={0}",1);
                
                  //  if else (count1 + count2 == 8)
                    
                     //    Console.WriteLine("No of intresting points={0}",1);
                    }
                else
                    Console.WriteLine("No of intresting points={0}", 0);
            }
           
            
            Console.ReadLine();

        }


        public static int[] intToArray(int num)
        {
            List<int> numbers = new List<int>();
            do
            {
                numbers.Insert(0, num % 10);
                num /= 10;
            } while (num > 0);
            return numbers.ToArray();
        }
}
            
}
        
    
        
    
