using ToDoListWebAPI.Models;

namespace ToDoListWebAPI.Services
{
    public class ToDoService
    {
        private readonly List<ToDoTask> _tasks = new();
        private int _nextId = 1;

        public List<ToDoTask> GetAll() => _tasks;

        public ToDoTask? GetById(int id) =>
            _tasks.FirstOrDefault(t => t.Id == id);

        public ToDoTask Add(string description)
        {
            var task = new ToDoTask()
            {
                Id = _nextId++,
                Description = description
            };
            _tasks.Add(task);
            return task;
        }
        public bool Update(int id, string newDescription) 
        {
            var task = GetById(id);
            if (task == null) return false;
            task.Description = newDescription;
            return true;
        }
        public bool Complete(int id)
        {
            var task = GetById(id);
            if (task == null) return false;
            task.IsCompleted = true;
            return true;
        }

        public bool Delete(int id)
        {
            var task = GetById(id);
            if (task == null) return false;
            _tasks.Remove(task);
            return true;
        }
    }
}