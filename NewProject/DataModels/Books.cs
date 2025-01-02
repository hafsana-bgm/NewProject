using System.ComponentModel.DataAnnotations;

namespace NewProject.DataModels
{
    public class Books
    {

        [Key]
        public int Id { get; set; }
        public string? BookName { get; set; }
        public string? BookDescription { get; set; }
        public int Stock { get; set; }
        public double BookPrice { get; set; }
        public string? Image { get; set; }
        public bool IsActive { get; set; }
    }
}
