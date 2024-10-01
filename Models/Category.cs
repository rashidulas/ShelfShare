namespace ShelfShare.Models
{
    public class Category
    {
        // [Key] - No need as "Id"/"CategoryId" is default key
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
    }
}