namespace TodoApi.Models
{
	public class TodoItem
	{
        public long Id { get; set; }    // exclusive key for realtional db
        public string? Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
