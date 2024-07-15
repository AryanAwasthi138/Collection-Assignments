namespace Lists_and_Dictionaries6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<Person,string> Person_Email = new Dictionary<Person,string>();
            var Person_1 = new Person("Aryan", "Awasthi");
            var Person_2 = new Person ("Mark", "Zukerberg");
            var Person_3 = new Person("Elon", "Musk");

            Person_Email[Person_1] = "aryanawasthi138@gmail.com";
            Person_Email[Person_2] = "zukerbergmark214@gmail.com";
            Person_Email[Person_3] = "alon54musk@gmail.com";

            Console.WriteLine("--> Emails of the persons are:");
            Console.WriteLine();
            foreach ( var person in Person_Email)
            {
                Console.WriteLine($"{person.Key.Firstname} {person.Key.Lastname}: {person.Value}");
            }

            Person_Email[Person_3] = "alonmusk654@gmail.com";
            Console.WriteLine($"\n--> Updated mail is:");
            Console.WriteLine();
            foreach( var person in Person_Email)
            {
                Console.WriteLine($"{person.Key.Firstname} {person.Key.Lastname}: {person.Value}");
            }

            Person_Email.Remove(Person_2);
            Console.WriteLine("\n-->Dictionary after removing Person_3 is:");
            Console.WriteLine();
            foreach (var person in Person_Email)
            {
                Console.WriteLine($"{person.Key.Firstname} {person.Key.Lastname}: {person.Value}");
            }



        }
    }
}