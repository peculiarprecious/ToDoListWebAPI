using Microsoft.AspNetCore.Mvc;
using ToDoListWebAPI.Models;
using ToDoListWebAPI.Services;

namespace ToDoListWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ToDoService _service;

        public TodosController(ToDoService service)
        {
            _service = service;
        }

        // GET api/todos
        [HttpGet]
        public IActionResult GetAll()
        {
            var tasks = _service.GetAll();
            return Ok(tasks);
        }

        // GET api/todos/1
        [HttpGet("{id}")]
        public IActionResult GetTaskById(int id)
        {
            var task = _service.GetById(id);
            if (task == null) return NotFound();    
            return Ok(task);
        }

        // POST api/todos
        [HttpPost]
        public IActionResult Add([FromBody] string description)
        {
            if (string.IsNullOrWhiteSpace(description))
                return BadRequest("Description cannot be empty");

            var task = _service.Add(description);
            return CreatedAtAction(nameof(GetTaskById), new { id = task.Id }, task);
        }

        // PUT api/todos/1
        [HttpPut("{id}")]                          
        public IActionResult Update(int id, [FromBody] string description)
        {
            if (string.IsNullOrWhiteSpace(description))
                return BadRequest("Description cannot be empty");

            var success = _service.Update(id, description);  
            if (!success) return NotFound();
            return Ok("Task updated!");
        }

        // PUT api/todos/1/complete
        [HttpPut("{id}/complete")]
        public IActionResult Complete(int id)
        {
            var success = _service.Complete(id);
            if (!success) return NotFound();
            return Ok("Task marked as complete!");
        }

        // DELETE api/todos/1
        [HttpDelete("{id}")]                        
        public IActionResult Delete(int id)
        {
            var success = _service.Delete(id);
            if (!success) return NotFound();
            return Ok("Task deleted!");
        }
    }
}