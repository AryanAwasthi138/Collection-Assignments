


namespace Lists_and_Dictionaries
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<string> fruits = new List<string>();
            fruits.Add("Guava");
            fruits.Add("Mango");
            fruits.Add("kiwi");
            fruits.Add("Pineapple");
            fruits.Add("Apple");
            Console.WriteLine("-->Fruits in the List are:");

            Viewfruitlist(fruits); 
            AddedFruit("Orange",fruits);
            RemoveFruit("Mango", fruits);

            fruits.Add("Orange");
            fruits.Remove("Mango");
            Console.ReadLine();   
        }

        public static void RemoveFruit(string fruit, List<string> fruits)
        {
            fruits.Remove(fruit);
            Console.WriteLine("-->Removed fruit from the list is:" +fruit);

            Viewfruitlist(fruits);
            Console.WriteLine("-->The third accessed fruit in the list is:" + fruits[3]);

            Console.WriteLine();

            if (fruits.Contains("Mango"))
            {
                Console.WriteLine("-->Yupp, the list contains the fruit you want.");
            }
            else
            {
                Console.WriteLine("-->Nope, the list doesn't contains the fruit you want.");
            }
            

        }
        public static void AddedFruit(string fruit, List<string> fruits)
        {
            fruits.Add(fruit);
            Console.WriteLine("-->New Added fruit in the list is:" +fruit);

            Viewfruitlist(fruits);
            {
                Console.WriteLine();
            }
          

        }

        public static void Viewfruitlist(List<string> fruits)
        {
            foreach (var fruit in fruits)
            {
                
               Console.WriteLine(fruit);
            }
               Console.WriteLine();
        }
    }
        
}
