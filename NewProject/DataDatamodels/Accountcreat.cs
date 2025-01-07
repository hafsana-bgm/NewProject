using System.ComponentModel.DataAnnotations;

namespace NewProject.DataDatamodels
{
    public class Accountcreat
    {

        [Key]
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }
    }
}
