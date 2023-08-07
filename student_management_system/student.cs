class Student{

    public string name;
    public readonly string  id;
    public int age;
    public float gpa;

    public Student(string name, string id, int age, float gpa){
        this.name = name;
        this.id = id;
        this.age = age;
        this.gpa = gpa;
    }

    public void ShowInfo(){
        Console.WriteLine("Name: " + name);
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Department: " + age);
        Console.WriteLine("CGPA: " + gpa);
    }

    

}
