using System.ComponentModel.DataAnnotations;

public class Book
{
    [Key] // This attribute specifies that 'Id' is the primary key
    public int Id { get; set; } // Primary key

    public string ISBN { get; set; }
    public string Title { get; set; }
    public int CategoryId { get; set; }
    public string Author { get; set; }

    public Category Category { get; set; }
}
