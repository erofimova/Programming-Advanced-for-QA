using System.Threading.Channels;

int n = int.Parse(Console.ReadLine());
List<Student> students = new List<Student>();

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split();
    string firstName = input[0];
    string lastName = input[1];
    double grade = double.Parse(input[2]);

    students.Add(new Student(firstName, lastName, grade));
    students = students.OrderByDescending(s => s.Grade).ToList();
}
Student ivan = new Student("vasf", "asfaf", 12);
foreach (var student in students)
{
    Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:F2}");
}
class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Grade { get; set; }
    public Student(string first, string second, double grade)
    {
        FirstName = first;
        LastName = second;
        Grade = grade;
    }
    
    
}



