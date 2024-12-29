using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularsQueues{
    internal class Program{
        static void Main(string[] args){
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            CircularQueue<string> queue = new CircularQueue<string>(7);
            queue.AddElement("1");
            queue.AddElement("2");
            queue.AddElement("3");
            queue.Print();
            Console.WriteLine("Перший елемент: " + queue.First());

            Console.WriteLine("Кількість елементів: " + queue.Count());
            Console.WriteLine("Видалено: " + queue.DelFirst());
            Console.WriteLine("Видалено: " + queue.DelFirst());

            queue.Print();

            queue.AddElement("4");
            queue.AddElement("5");
            queue.AddElement("6");
            queue.AddElement("7");
            queue.AddElement("8");
            queue.AddElement("9");
            queue.Print();
            Console.WriteLine("Перший елемент: " + queue.First());
            queue.AddElement("A");
            queue.AddElement("B");
            queue.Print();

            Console.WriteLine("Видалено: " + queue.DelFirst());
            Console.WriteLine("Видалено: " + queue.DelFirst());
            
            queue.Print();
            Console.WriteLine("Перший елемент: " + queue.First());
        }
    }
}
