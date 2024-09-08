class Student{
    public string? Name { get; set; }
    public int Score { get; set; }
    public void Where(){
        List<Student> students = new List<Student>
  {
    new Student{Name="Sakib" ,Score=80},
    new Student{Name="Afnan",Score = 100},
    new Student{Name="Akhi",Score=90},
    new Student{Name="Robin",Score=68},
    new Student{Name="kumar",Score=70},

  };
  var highestScorer = students.Where(student=>student.Score>=80);
  foreach(var item in highestScorer){
    Console.WriteLine($"Name:{item.Name} Score:{item.Score}");
  }
    }
}
