public class TaskManager {
    private List<Task> tasks;

    public TaskManager() {
        tasks = new List<Task>();

    }

public  async void LoadTasks(string filePath = "example.csv") {
    using (StreamReader reader = new StreamReader(filePath)) {
        string line;
        while ((line = await reader.ReadLineAsync()) != null) {
            string[] taskDetails = line.Split(',');
            Task task = new Task {
                Name = taskDetails[0],
                Description = taskDetails[1],
                Category = (TaskCategory)Enum.Parse(typeof(TaskCategory), taskDetails[2]),
                IsCompleted = bool.Parse(taskDetails[3]),
            };
            tasks.Add(task);
            
        }
    }
}

    public void AddTask(Task task) {
        tasks.Add(task);
        WriteTask("example.csv", task);
    }

    public async void WriteTask(string filePath, Task task) {
        using (StreamWriter writer = new StreamWriter(filePath, true)) {
            await writer.WriteLineAsync($"{task.Name},{task.Description},{task.Category},{task.IsCompleted}");
        }
    }

    public void UpdateTask(Task task) {
        Task taskToUpdate = tasks.Find(t => t.Name == task.Name);
        taskToUpdate.Description = task.Description;
        taskToUpdate.Category = task.Category;
        taskToUpdate.IsCompleted = task.IsCompleted;
    }

    public void DisplayTasks() {
        Console.WriteLine("Tasks:");
        foreach (Task task in tasks) {
            Console.WriteLine(task);
        }
    }

    public void DisplayTasksByCategory(TaskCategory category) {
        Console.WriteLine($"Tasks in category: {category}");
        //lambda filter
        foreach (Task task in tasks.Where(t => t.Category == category)) {
            Console.WriteLine(task);
        }
    }
}