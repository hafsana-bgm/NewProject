using System.ComponentModel.DataAnnotations;

namespace NewProject.DataDatamodels
{
    public class AllProduct
    {
        [Key]
        public int Id { get; set; }

        public string? ProductName { get; set; }

        public string? ProductImage { get; set; }

        public string? ProductPrice { get; set; }

        public string? ProductCondition { get; set; }

        public string? ProductDescription { get; set; }
    }
}
