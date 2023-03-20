using System.Collections.Concurrent;

namespace _20._3
{
    internal class Program
    {
        public static Citac c = new Citac();
        public static Random rd = new Random();
        public static List<int> l = new List<int>();
        public static ConcurrentBag<int> cb = new ConcurrentBag<int>();
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(Zvysit));
            Thread t2 = new Thread(new ThreadStart(Snizit));
            Thread t3 = new Thread(new ThreadStart(Generuj));
            Thread t4 = new Thread(new ThreadStart(Generuj));
            Thread t5 = new Thread(new ThreadStart(Generuj2));
            Thread t6 = new Thread(new ThreadStart(Generuj2));
            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            t5.Start();
            t6.Start();
            t1.Join();
            t2.Join();
            t3.Join();
            t4.Join();
            t5.Join();
            t6.Join();
            Console.WriteLine(c.hodnota);
            Console.WriteLine(l.Count);
            Console.WriteLine(cb.Count);
        }
        
        public static void Zvysit()
        {
            for (int i = 0; i < 1000000; i++)
            {
                c.Zvys();
            }
        }

        public static void Snizit()
        {
            for (int i = 0; i < 1000000; i++)
            {
                c.Sniz();
            }
        }

        public static void Generuj()
        {
            for(int i = 0; i < 1000000; i++)
            {
                l.Add(rd.Next(10));
            }
        }
        public static void Generuj2()
        {
            for (int i = 0; i < 1000000; i++)
            {
                cb.Add(rd.Next(10));
            }
        }
    }
}