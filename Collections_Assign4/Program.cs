

using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

namespace Lists_and_Dictionaries4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string,double> dictionary = new Dictionary<string,double>();
            dictionary.Add("Perfume", 200.45);
            dictionary.Add("Chocolate", 90.95);
            dictionary.Add("Colddrink", 120.85);
            dictionary.Add("Laptop", 90000.45);
            dictionary.Add("Powerbank", 1020.45);
            Console.WriteLine("-->The names of product and their prices are:");

            View_Items(dictionary);
            Console.WriteLine();
            Console.WriteLine("-->Average of all the products is:" + Average_Price(dictionary, 5));
            Console.WriteLine();

            var Most_Expensive = dictionary.Values.Max();
            Console.Write("-->The most expensive product is:");
            Expensive_Item(dictionary);
            Console.WriteLine();
            Console.WriteLine("-->The price of most expensive item is:" + Most_Expensive);
        }

        public static void Expensive_Item(Dictionary<string, double> dictionary)
        {
            var Most_Expensive = dictionary.Values.Max();

            foreach (KeyValuePair<string,double> item in dictionary)
            {
                if(item.Value == Most_Expensive)
                {
                    string Keyy = item.Key;
                    Console.WriteLine(Keyy);
                }
            }
           

        }

        public static double Average_Price(Dictionary<string, double> dictionary,int product)
        {
            double sum = 0;
            foreach (KeyValuePair<string,double> item in dictionary)
            {
                sum = sum + item.Value;
                sum = sum/product;
            }
             return sum;    
            
        }

        public static void View_Items(Dictionary<string, double> dictionary)
        {
            foreach(var item in dictionary)
            {
                Console.WriteLine(item);
            }
        }
    }
}