using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    internal class RandomClass
    {
        public void RandomList()
        {
            List<int> ints = new List<int>();
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                ints.Add(random.Next(0, 500));


            }
            ints.Sort();
            for (int i = 0; i < ints.Count; i++)
            {
                Console.Write(ints[i] + " ");
            }
        }
        public void RandomArr()
        {
            int[] arr = new int[20];
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 100);
            }
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        public void RandomQueue()
        {
            Queue<int> q = new Queue<int>();
            Random rand = new Random();
            for (int i = 0; i < 20; i++)
            {
                q.Enqueue(rand.Next(0, 200));
            }            
            q = new Queue<int>(q.OrderBy(q => q));            
            foreach (int i in q)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        public void RandomSteck()
        {
            Stack<int> ints = new Stack<int>();
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                ints.Push(random.Next(0, 300));
            }
            
            
            Console.WriteLine( String.Join(",", ints));
        }
    }
}