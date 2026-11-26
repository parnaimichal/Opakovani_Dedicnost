class Lambda 
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class Grade
    {
        public int StudentId { get; set; }
        public int GradeValue{ get; set; }
    }
    static void Main()
    {
        List<int> numbers = new List<int>
        {
            3, 8, 11, 15, 20, 4, 7
        };
        
        var result = numbers.Where(x => x % 2 == 0); 
        
        var result2 = numbers
            .Where(x => x % 2 == 0)
            .OrderByDescending(x => x);
        
        
        List<int> numbers2 = new List<int> { 2, 4, 6, 8 };
        
        var result3 = numbers2
            .Select(x => x * x );
        
        List<int> numbers3 = new List<int> { 2, 5, 8, 11, 14, 17 };
     
        var result4 = numbers3
            .Where(x => x > 7)
            .Select(x => x * 3)
            .OrderByDescending(x => x);
        
        List<int> numbers4 = new List<int> { 3, 8, 12, 5, 17, 4 };

        var result5 = numbers4
            .Any(x => x > 7);
        
        List<int> numbers5 = new List<int> { 4, 7, 12, 15, 20 };

        var result6 = numbers5
            .FirstOrDefault(x => x > 30);
        
        List<int> numbers7 = new List<int> { 5, 8, 13, 21, 4, 18 };

        var result7 = numbers7
            .Last(x => x > 10);
        
        List<int> numbers8 = new List<int> { 4, 12, 7, 19, 25, 8, 16 };
        
        var result8 = numbers8
            .Where(x => x > 10)
            .Select(x => x * 2)
            .OrderByDescending(x => x);
                    
        List<int> numbers9 = new List<int> { 5, 14, 8, 21, 30, 11, 6 };
        
        var result9 = numbers9
            .Where(x => x %  2 == 0)
            .Select(x => x * 3)
            .OrderBy(x => x);
        
        
        List<string> names7 = new List<string>
        {
            "Petr", "Anna", "Karel", "Adam", "Eva", "Tomáš", "Jan"
        };

        var resultnames = names7
            .OrderBy(x => x.Length)
            .ThenBy(x => x);
        
            
        
        foreach (var item in resultnames)
            {
            Console.WriteLine(item);
            }
        
        List<string> cities7 = new List<string>
        {
            "Praha", "Brno", "Praha", "Ostrava", "Brno", "Praha"
        };

        var resultcities = cities7
            .GroupBy(x => x);

        foreach (var group in resultcities)
        {
            Console.WriteLine(group.Key + " -> " + group.Count());
        }

        
        
        List<int> numbers10 = new List<int>
        {
            2, 5, 2, 8, 5, 2, 8, 10
        };
        
        var result10 = numbers10
            .GroupBy(x => x);

        foreach (var group in result10)
        {
            Console.WriteLine(group.Key + " -> " + group.Count());
        }
        
        List<int> numbers13 = new List<int>
        {
            4, 7, 4, 2, 9, 7, 2, 11, 9, 4
        };

        var result13 = numbers13
            .Distinct();

        foreach (var item in result13)
        {
            Console.WriteLine(item);
        }
        
        
        List<int> numbers15 = new List<int>
        {
            4, 9, 15, 22, 31
        };
        
        bool result14 = numbers15.Contains(15);
        bool result15 = numbers15.Contains(20);

        
        List<int> numbers16 = new List<int>
        {
            3, 7, 14, 22, 5, 9
        };


        var result16 = numbers16;
       
        bool result17 = numbers16.Any(x => x > 20);
        bool result18 = numbers16.Contains(14);
        
        bool result19 = numbers16.All(x => x > 0);

        
        List<List<int>> numbers20 = new List<List<int>>
        {
            new List<int> { 2, 4 },
            new List<int> { 6, 8, 10 },
            new List<int> { 12, 14 }
        };


        var result20 = numbers20
            .SelectMany(x => x);
        
        foreach (var item in result20)
        {
            Console.WriteLine(item);
            
        }

        List<List<string>> names21 = new List<List<string>>
        {
            new List<string> { "Petr", "Jan" },
            new List<string> { "Anna", "Eva", "Lucie" },
            new List<string> { "Karel" }
        };
        
        var result21 = names21
            .SelectMany(x => x)
            .Where(x => x.Length > 3);
        
        foreach (var item in result21)
        {
            Console.WriteLine(item);
            
        }
        
        
        List<int> numbers23 = new List<int>
        {
            2, 4, 3
        };
        
        var result23 = numbers23.Aggregate((x, y) => x + y);
            
        
        List<int> numbers24 = new List<int>
        {
            5, 2, 3
        };
        
        var result24 = numbers24.Aggregate(10, (x, y) => x + y);

        List<string> names26 = new List<string>
        {
            "Petr", "Anna", "Karel"
        };
        
        var result26 = names26.ToDictionary(x => x, x => x.Length);
        
        foreach (var item in result26)
        {
            Console.WriteLine(item);}
        
        List<string> names28 = new List<string>
        {
            "Petr", "Anna", "Karel", "Adam", "Eva"
        };

        var result28 = names28.ToLookup(x => x.Length);
        
        
        
        
        List<Student> students29 = new List<Student>
        {
            new Student { Id = 1, Name = "Petr" },
            new Student { Id = 2, Name = "Anna" },
            new Student { Id = 3, Name = "Karel" }
        };

        List<Grade> grades29 = new List<Grade>
        {
            new Grade { StudentId = 1, GradeValue = 2 },
            new Grade { StudentId = 2, GradeValue = 1 },
            new Grade { StudentId = 3, GradeValue = 3 }
        };
        
        
        
      var result29 = students29
          .Join(grades29, Student => Student.Id, Grade => Grade.StudentId,
              (student, grade) => new
          {
              student.Name,
              grade.GradeValue
          });
      foreach (var item in result29)
      {
          Console.WriteLine(item);
      }
      
      var result30 = students29
          .GroupJoin(grades29, student => student.Id, Grade => Grade.StudentId,
              (student, grade) => new { Student = student.Name, Grade = grade });

      foreach (var item in result30)
      {
          Console.WriteLine(item.Student);

          foreach (var grade in item.Grade)
          {
              Console.WriteLine(grade.GradeValue);
          }
      }
      
    }
}
