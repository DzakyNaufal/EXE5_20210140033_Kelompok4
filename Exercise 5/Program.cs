using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    class Node 
    {
        public string nama;
        public Node next;
       
    }
    class Queue
    {
        Node dzaky, naufal;
        public Queue()
        {
            dzaky = null;
            naufal = null;
        }

        public void insert(string nm)
        {
            Console.Write("\nMasukkan nama Mahasiswa");
            nm = Console.ReadLine();
            Node nodeBaru = new Node();
            nodeBaru.nama = nm;
            nodeBaru.next = null;

            if (dzaky == null)
            {
                dzaky = nodeBaru;
                naufal = nodeBaru;
                return;
            }
            naufal.next = nodeBaru;
            dzaky = nodeBaru;
        }

        public void delete()
        {
            if (dzaky == null)
            {
                Console.WriteLine("Kosong!!");
                return;
            }
            naufal = naufal.next;

            if (dzaky == null)
                naufal = null;
        }

        public void display()
        {
            if (dzaky == null)
            {
                Console.WriteLine("Kosong");
                return;
            }
            Node display;
        }

        static void Main(string[] args)
        {
            Queue q = new Queue();
            char ch;
            while (true)
            {
                try
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("1. Implement insert operation");
                    Console.WriteLine("2. Implement delete operation");
                    Console.WriteLine("3. Display values");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine("\nEnter your choice (1-4): ");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
                    {
                        
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Check for the values entered");
                }
            }
        }
    }
}
