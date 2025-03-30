namespace task_manager.Core.Interfaces;

using task_manager.Core.Models;

public interface ITaskService {
    void AddTask(string Title, string description);
    void ViewTask();
    void MarkTaskCompleted(int taskId);
    void DeleteTask(int taskId);
}
