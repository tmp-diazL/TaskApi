using System.Collections.Generic;

namespace TaskApi.Data.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }

        public List<Task> Tasks { get; set; }
    }
}