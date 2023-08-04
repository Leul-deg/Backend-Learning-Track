// Create the Task enum to represent different task categories.
// Define the Task class with the necessary properties.
// Implement the Task Manager class with methods for adding, viewing, filtering, and updating tasks.
// Use lambda expressions to filter tasks based on categories.
// Add asynchronous file read/write methods using async/await for data persistence
// Implement exception handling for file operations and user input validation.
public enum TaskCategory {
    Personal,
    Work,
    Errands,
    School,
    Other
}

public class Task {
    public string? Name { get; set; }
    public string? Description { get; set; }
    public TaskCategory Category { get; set; }
    public bool IsCompleted { get; set; }

    public override string ToString() {
        return $"Name: {Name}\nDescription: {Description}\nCategory: {Category}\nIs Completed: {IsCompleted}";
    }
}
