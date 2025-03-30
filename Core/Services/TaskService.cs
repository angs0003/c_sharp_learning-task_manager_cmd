namespace task_manager.Core.Services;

using System;
using System.Collections.Generic;
using System.Linq;
using task_manager.Core.Interfaces;
using task_manager.Core.Models;

public class TaskService : ITaskService {
    private readonly List<TaskItem> _tasks = new List<TaskItem>();
    private int _nextId = 1;

    public void AddTask(string title, string description){
        var task = new TaskItem(_nextId++, title, description);
        _tasks.Add(task);
        Console.WriteLine("✅ Task added successfully.");
    } 


    public void ViewTask() {
        if (!_tasks.Any()){
            Console.WriteLine("No task available");
            return;
        } 

        Console.WriteLine("\nYour Tasks:");
        foreach (var task in _tasks){
            Console.WriteLine(task);
        }
    }

    public void MarkTaskCompleted(int taskId) {
        var task = _tasks.FirstOrDefault( t => t.Id == taskId);
        if (task == null) {
            Console.WriteLine("⚠️ Task not found.");
            return;
        } 
        task.isCompleted = true;
        Console.WriteLine("✅ Task marked as completed.");
 
    }


    public void DeleteTask(int taskId){
        var task = _tasks.FirstOrDefault(t => t.Id == taskId);
        if (task == null) {
            Console.WriteLine("⚠️ Task not found.");
        }

        _tasks.Remove(task);
        Console.WriteLine("🗑️ Task deleted successfully.");
    }
}