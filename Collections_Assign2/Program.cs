using System.ComponentModel.Design;

namespace Lists_and_Dictionaries2
{
    public class Program
    {
        public static void Main(string[] args)
        {
           List<int> list = new List<int>();
            list.Add(11);
            list.Add(21);
            list.Add(31);
            list.Add(42);
            list.Add(55);
            list.Add(16);
            list.Add(72);
            list.Add(8);
            list.Add(90);
            list.Add(10);
            Console.WriteLine("-->Integer in the List are given Below:");

            ViewList(list);
            Console.WriteLine();
            Sortlist(list);
            ViewList(list);
            Console.WriteLine();
            Reverselist(list);
            ViewList(list);
            if (list.Contains(10))
            {
                Console.WriteLine("-->Yupp, the list contains the entered integer.");
            }
            else
            {
                Console.WriteLine("-->Nope, the list doesn't contain the entered integer.");

            }
            {

            }
        }

        public static void Reverselist(List<int> list)
        {
            list.Reverse();
            Console.WriteLine("-->Sorted list in the Descending order is:");
 
        }

        public static void Sortlist(List<int> list)
        {
           list.Sort();
           Console.WriteLine("-->Sorted list in the Ascending order is:");
        }
             
        public static void ViewList(List<int> list)
        {
            foreach(var integer  in list)
            {
                Console.WriteLine(integer);
            }
        }
    }
}