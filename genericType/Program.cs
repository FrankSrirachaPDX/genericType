using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericType
{
    public class Employee<T>
    {
        public List<T> thing = new List<T>();

    }

    public class Program
    {
        static void Main(string[] args)
        {
            Employee<string> objStr = new Employee<string>();
            Employee<int> objInt = new Employee<int>();
            bool stop1 = false, stop2 = false;
            int x = 0, y = 0;


            objStr.thing.Add("This is a string");
            objStr.thing.Add("This is another string");
            objStr.thing.Add("This is the last string");

            objInt.thing.Add(24);
            objInt.thing.Add(214);
            objInt.thing.Add(999);

            do
            {
                if (x < objStr.thing.Count)
                {
                    Console.WriteLine(objStr.thing[x]);
                    x++;
                }
                else { stop1 = true; }

                if (y < objInt.thing.Count)
                {
                    Console.WriteLine(objInt.thing[y]);
                    y++;
                }
                else { stop2 = true; }
            } while (stop1 != true && stop2 != true);

            Console.ReadLine();

        }
    }
}
