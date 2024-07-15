namespace Lists_and_Dictionaries5
{




    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> studentScores = new Dictionary<string, List<int>>();

            studentScores.Add("Harry", new List<int> { 85, 90, 78 });
            studentScores.Add("Shraddha", new List<int> { 92, 88, 84 });
            studentScores.Add("Aman", new List<int> { 78, 85, 80 });

            Console.WriteLine("--> Scores of the students are:");
            foreach (var student in studentScores)
            {
                Console.WriteLine($"{student.Key}: {string.Join(", ", student.Value)}");
            }

            Console.WriteLine("\n --> Average Scores of the students are:");
            Dictionary<string, double> Average = new Dictionary<string, double>();
            foreach (var student in studentScores)
            {
                double average = student.Value.Average();
                Average.Add(student.Key, average);
                Console.WriteLine($"{student.Key}: {average}");
            }

            var topStudent = Average.Aggregate((x, y) => x.Value > y.Value ? x : y);
            Console.WriteLine($"\n--> Student {topStudent.Key} is with an highest average score of: {topStudent.Value}");
        }
    }
}