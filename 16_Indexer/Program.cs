using _16_Indexer.Models;

namespace _16_Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Number list = new Number();
            list.Add(1);
            list.Add(3);
            list.Add(4);
            list.Add(6);
            list.Add(7);
            list.Add(4);
            list.Add(68);

            list.GetElement();
            list.IndexOf(4);
            list.LastIndexOf(4);
            Console.WriteLine(list[8]);

        }
    }
}
