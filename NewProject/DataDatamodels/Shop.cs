using System.ComponentModel.DataAnnotations;

namespace NewProject.DataDatamodels
{
    public class Shop
    {
        [Key]
        public int Id { get; set; }

        public string? ProductName { get; set; }

        public string? ProductImage { get; set; }

        public string? ProductPrice { get; set; }
    }
}
