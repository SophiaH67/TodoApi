namespace TodoApi.Models;

public class TodoItem
{
    public TodoItem()
    {
        Id = Guid.NewGuid().ToString();
    }
    public string Id { get; set; }
    public string? Name { get; set; }
    public bool IsComplete { get; set; }
}