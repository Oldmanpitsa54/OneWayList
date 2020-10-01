using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace OneWayList
{
    class Program
    {
        static void Main(string[] args)
        {
            cOneWayList list = new cOneWayList();
            list.Add("pitsa");
            list.Add("sushi");
            list.Add("burrito");
            list.Add("taco");
            list.Add("ramen");

            cOneWayList shitList = new cOneWayList();
            shitList.Add("ramen");
            shitList.Add("sushi");
            
            cOneWayList.Except(ref list, shitList);

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

        }
    }
}
