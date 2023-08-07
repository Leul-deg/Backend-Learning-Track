using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
class StudentList<T> where T : Student {
    private List<T> students = new List<T>();

    public void AddStudent(T student) {
        students.Add(student);
    }

    public void RemoveStudent(T student) {
        students.Remove(student);
    }

    public List<T> SearchByName(string name) {
        var result = from student in students
                     where student.Name == name
                     select student;
        return result.ToList();
    }

    public void SaveToJson(string filePath) {
        string jsonString = JsonSerializer.Serialize(students);
        File.WriteAllText(filePath, jsonString);
    }

    public void LoadFromJson(string filePath) {
        string jsonString = File.ReadAllText(filePath);
        students = JsonSerializer.Deserialize<List<T>>(jsonString);
    }
}


