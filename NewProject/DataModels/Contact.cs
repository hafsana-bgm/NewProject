using System.ComponentModel.DataAnnotations;

namespace NewProject.DataModels
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        public string? YourName { get; set; }
        public string? PhoneNumber{ get; set; }
        public string? Email { get; set; }
        public string? Message { get; set; }
       
    }
}
