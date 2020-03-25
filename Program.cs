using System;
using System.Collections;



namespace _4_5_LAB
{
    class Program
    {
        static void Main(string[] args)
        { 
        
          ArrayList scores = new ArrayList();
            scores.Add(4400);
            scores.Add(6800);
            scores.Add(8900);
            scores.Add(1200);
            scores.Add(3700);
            scores.Add(7200);

            foreach ( int item in scores)
            {
                Console.WriteLine(item);
                Console.ReadLine();
            }

            scores.Sort();
            foreach(int item in scores)
            {
                Console.WriteLine(item);
            }
            scores.Reverse();
            foreach(int item in scores)
            {
                Console.WriteLine(item);
            }
            scores.Add(2400);
            foreach (int item in scores) 
            {
                Console.WriteLine(item + " ");
                
            }
            scores.Remove(4400);
            foreach (int item in scores)
            {
                Console.WriteLine(item);
            }

        }   
    }      
}
