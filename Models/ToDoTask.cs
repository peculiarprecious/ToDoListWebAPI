namespace ToDoListWebAPI.Models
{
    public class ToDoTask
    {
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public bool IsCompleted { get; set; }
        public DateTime createdAt { get; set; } = DateTime.Now;
    }
}
