class Person{
    public string? Name{get;set;}
    public int Age{get;set;}
    public string? BloodGroup { get; set; }
}
class Select{
    public void Test(){
           int[] numbers = {1,2,3,4,5};
   var squareNumbers = numbers.Select(num=>num*num);
   foreach(var item in squareNumbers){
    Console.Write($"{item} ");
   }
   Console.WriteLine();
   List<Person> people = new List<Person>
   {
        new Person{Name="Sakib",Age=27,BloodGroup="A+"},
        new Person{Name="Akhi",Age=26,BloodGroup="B+"},
        new Person{Name="Afnan",Age=2,BloodGroup="AB+"}
   };
   var names = people.Select(person=>(person.Name,person.BloodGroup));
   foreach(var name in names){
    Console.Write($"{name.Name} {name.BloodGroup} ");
   }

    /*

    Select
    many

    */


    List<List<int>> nestedLists = new List<List<int>>
  {
    new List<int>{1,2,3},
    new List<int>{4,5},
    new List<int>{6,7,8},
    new List<int>{9}
  };
  var flattedList = nestedLists.SelectMany(list=>list);
  foreach(var item in flattedList){
    Console.Write($"{item} ");
  }

    }
     
}