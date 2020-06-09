using System;

namespace TodoApi.Models
{
    public class TodoItem
    {
        public TodoItem(long id, string name, bool isComplete)
        {
            this.Id = id;
            this.Name = name;
            this.IsComplete = isComplete;
        }

        public long Id { get; set; }

        public string Name { get; set; }

        public bool IsComplete { get; set; }
    }
}
