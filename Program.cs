// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using task_manager.Core.Services;
using task_manager.UI;

class Program
{
    static void Main()
    {
        var taskService = new TaskService();
        var taskUI = new TaskUI(taskService);
        taskUI.run();
    }
}
