namespace task_manager.UI; 

using System;
using task_manager.Core.Interfaces;

public class TaskUI {
    private readonly ITaskService _taskService;

    public TaskUI(ITaskService taskService){
        _taskService = taskService;
    }

    public void run(){
        while (true){
            Console.WriteLine("\nTask Manager Menu:");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. View Tasks");
            Console.WriteLine("3. Mark Task as Completed");
            Console.WriteLine("4. Delete Task");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string input = Console.ReadLine();
            switch (input) {
                case "1": 
                    Console.Write("Enter title: ");
                    string title = Console.ReadLine();
                    Console.Write("Enter Description: ");
                    string description = Console.ReadLine();
                    _taskService.AddTask(title, description);
                    break;
                case "2":
                    _taskService.ViewTask();
                    break;
                case "3":
                    Console.Write("Enter Task ID to complete: ");
                    if (int.TryParse(Console.ReadLine(), out int completeId))
                        _taskService.MarkTaskCompleted(completeId);
                    else
                        Console.WriteLine("⚠️ Invalid ID.");
                    break;
                case "4":
                    Console.Write("Enter Task ID to delete: ");
                    if (int.TryParse(Console.ReadLine(), out int deleteId))
                        _taskService.DeleteTask(deleteId);
                    else 
                        Console.WriteLine("⚠️ Invalid ID.");
                        break;
                case "5":
                    Console.WriteLine("Exiting Task Manager...");
                    return;
                default:
                    Console.WriteLine("⚠️ Invalid option. Try again.");
                    break;
            }    
        }
    }
}