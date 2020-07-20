using System;

namespace oop_id_w02
{
    class Program
    {
        static void Main(string[] args)
        {
            Room r433 = new Room();
            Room r434 = new Room("434","434",4,4,"Computer");
            Console.WriteLine(r433);
            Console.WriteLine(r434);
            Console.WriteLine("Hello World!");
        }
    }
}
