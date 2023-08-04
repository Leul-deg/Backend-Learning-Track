using System;
using System.IO;
using System.Threading.Tasks;

class Program {
    static void Main(string[] args) {
       

        TaskManager taskManager = new TaskManager();
        taskManager.LoadTasks();

        Console.WriteLine("Enter a task name:");
        string name = Console.ReadLine();
        Console.WriteLine("Enter a task description:");
        string description = Console.ReadLine();
        Console.WriteLine("Enter a task category:");
        string category = Console.ReadLine();
        Console.WriteLine("Enter a task completion status:");
        string isCompleted = Console.ReadLine();
        
        try{

            Task task = new Task {
                Name = name,
                Description = description,
                Category = (TaskCategory)Enum.Parse(typeof(TaskCategory), category),
                IsCompleted = bool.Parse(isCompleted)
            };

            taskManager.AddTask(task);


        }
        catch (Exception ex) when (name == "") {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
        catch (Exception ex) when (description == "") {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
        catch (Exception ex) when (category == "") {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
        catch (Exception ex) when (isCompleted == "") {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
        catch (Exception ex) {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
        // finally {
        //     Console.WriteLine("The finally block is always executed.");
        // }

    }
}
