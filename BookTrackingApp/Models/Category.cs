public class Category
{
    public int Id { get; set; }
    public string NameToken { get; set; }
    public int CategoryTypeId { get; set; }
    public string Description { get; set; }

    public CategoryType CategoryType { get; set; }
}
