using _01._Students;

int countStudents = int.Parse(Console.ReadLine());

List<Student> students = new List<Student>();

for (int count = 1; count <= countStudents; count++)
{
    string data = Console.ReadLine();
    string[] dataParts = data.Split(" ");

    string firstName = dataParts[0];
    string lastName = dataParts[1];
    double grade = double.Parse(dataParts[2]);

    Student student = new(firstName, lastName, grade);
    students.Add(student);
}

students = students.OrderByDescending(s => s.Grade).ToList(); //сортираме списъка със студент по оценка

foreach (Student student in students)
{
    Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:F2}");
}