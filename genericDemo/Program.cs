using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataSource<string> store = new DataSource<string>();
            store.Data = "Hello World!";
            Console.WriteLine(store.Data);
            
            DataSource<int> intst = new DataSource<int>();
            intst.Data = 1;
            Console.WriteLine(intst.Data);

            KeyValuePair<int, string> kvp = new KeyValuePair<int, string>();
            kvp.Key = 100;
            kvp.Value = "Hundred";
            Console.WriteLine($" {kvp.Key}  {kvp.Value}");

            KeyValuePair<string, string> kvp2 = new KeyValuePair<string, string>();
            kvp2.Key = "IT";
            kvp2.Value = "Information Technology";
            Console.WriteLine($" {kvp.Key}  {kvp.Value}");

            int a1 = 1;
            int a2 = 2;
            DataSource<int>.Swap(ref a1, ref a2);
            Console.WriteLine(a1);
            Console.WriteLine(a2);

            Console.ReadLine();
        }
    }
}
