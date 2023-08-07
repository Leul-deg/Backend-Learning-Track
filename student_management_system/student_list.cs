class StudentList<T>{


    private List<T> students = new List<T>();

    public void AddStudent(T student){
        students.Add(student);
    }

    public void RemoveStudent(T student){
        students.Remove(student);
    }

    public void SearchByName(string name){
        
        var student = from student in students
        where student.name == name
        select student;
        
        }



        // private int count;


}