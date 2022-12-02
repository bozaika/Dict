using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dict
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int > MyD = new Dictionary<string, int>();
            MyD.Add("One", 1);
            MyD.Add("Two", 2);
            MyD.Add("Three",3);
            MyD.Add("Four",4);
            MyD.Add("Five",5);
            MyD.Add("Six",6);
            MyD.Add("Seven",7);
            MyD.Add("Eight",8);
            MyD.Add("Nine",9);

            foreach (var key in MyD.Keys)
            {
                Console.WriteLine(MyD[key]);
            }
            Console.WriteLine("============");
            Console.WriteLine(MyD["Three"]);
            Console.WriteLine("============");
            if (MyD.ContainsKey("Ten"))
                Console.WriteLine(MyD["Ten"]);
            else
                Console.WriteLine("There is no Ten");
            Console.WriteLine("============");
            MyD.Remove("Four");

            foreach (var key in MyD.Keys)

            {
                Console.WriteLine(MyD[key]);
            }

            Console.WriteLine(MyD.Count);
            Console.WriteLine("============");
            Console.ReadKey();
        }
    }
}
