class Candidate{
    public string? Name { get; set; }
    public int Age { get; set; }
}
class LINQ
{
    public static void Main(string[] args)
    {
        List<Candidate> candidates = new List<Candidate>
        {
            new Candidate{Name="Sakib",Age=27},
            new Candidate{Name="Akhi",Age=26},
            new Candidate{Name="Afnan",Age=2}
        };
        var sortedCandidates = candidates.OrderBy(candidate=>candidate.Age).ThenBy(candidate=>candidate.Name);
        foreach(var item in sortedCandidates){
            Console.WriteLine($"{item.Name} {item.Age}");
        }
        bool isALL = candidates.All(candidate=>candidate.Age>18);
        bool isAny = candidates.Any(candidate=>candidate.Age>18);
        bool isAfnan = candidates.Select(candidate=>candidate.Name).Contains("Afnan");
        Console.WriteLine($"All:{isALL}");
        Console.WriteLine($"Any:{isAny}");
        Console.WriteLine($"All:{isAfnan}");

    }
}