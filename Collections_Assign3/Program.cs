using System.Security.Cryptography.X509Certificates;

namespace Lists_and_Dictionaries3
{
    public class Program
    {
        public static void Main(string[] args)
        {
           Dictionary<string,int> dictionary = new Dictionary<string,int>();
            dictionary.Add("Aryan:", 5);
            dictionary.Add("Malong:", 4);
            dictionary.Add("Fanzendong:", 3);
            dictionary.Add("Xuxin:", 2);
            dictionary.Add("Sharadkamal:", 1);
            Console.WriteLine("-->Dictionary with the student name and their scores is given below:");

            View_Dict(dictionary);
            Console.WriteLine();
            Update_Dict(dictionary);
            View_Dict(dictionary);
            Console.WriteLine();
            Remove_Dict(dictionary);
            View_Dict(dictionary);
            Console.WriteLine();
            Console.WriteLine("-->The score of fanzendong is:"+ dictionary["Fanzendong:"]);

        }

        public static void Remove_Dict(Dictionary<string, int> dictionary)
        {
            dictionary.Remove("Xuxin:");
            Console.WriteLine("-->Dictionary after removal of student is:");

        }

        public static void Update_Dict(Dictionary<string, int> dictionary)
        {
            dictionary["Aryan:"] = 9;
            Console.WriteLine("-->Updated Dictionary is:");
        }

        public static void View_Dict(Dictionary<string, int> dictionary)
        {
            foreach(var scores  in dictionary)
            {
                Console.WriteLine(scores);
            }
        }
    }
}