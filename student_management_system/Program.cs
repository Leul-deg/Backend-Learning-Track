class Program {
    static void Main(string[] args) {
        StudentList<Student> studentList = new StudentList<Student>();
        studentList.AddStudent(new Student { Name = "Alice", Age = 20 });
        studentList.AddStudent(new Student { Name = "Bob", Age = 21 });
        studentList.AddStudent(new Student { Name = "Charlie", Age = 22 });

        string filePath = "students.json";
        studentList.SaveToJson(filePath);

        StudentList<Student> loadedStudentList = new StudentList<Student>();
        loadedStudentList.LoadFromJson(filePath);

        Console.WriteLine("Loaded students:");
        foreach (Student student in loadedStudentList.SearchByName("Alice")) {
            Console.WriteLine($"{student.Name}, {student.Age}");
        }
    }
}