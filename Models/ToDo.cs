namespace LinqDemo.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime? CompletionDate { get; set; }
    }
}
