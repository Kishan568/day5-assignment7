using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conday5ass_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList fruits = new ArrayList();
            fruits.Add("apple");
            fruits.Add("banana");
            fruits.Add("cherry");
            fruits.Add("date");
            fruits.Add("elderberry");
            Console.WriteLine("Total number of elements in the ArrayList: " + fruits.Count);
            bool containsDate = fruits.Contains("date");
            Console.WriteLine("Does the ArrayList contain 'date'? " + containsDate);
            fruits.Insert(1, "fig");
            fruits.Remove("banana");
            Console.WriteLine("Elements in the ArrayList:");
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
        }
    }
}
