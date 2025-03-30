namespace task_manager.Core.Models;

public class TaskItem {
    public int Id {get; set;}
    public string Title {get; set;}
    public string Description {get; set;}
    public bool isCompleted {get; set;}

    public TaskItem(int id, string title, string description){
        Id = id;
        Title = title;
        Description = description;
        isCompleted = false;
    }

    public override string ToString(){
        return $"{Id}. {Title} - {(isCompleted ? "✅ Completed" : "❌ Pending")}";
    }
}
    