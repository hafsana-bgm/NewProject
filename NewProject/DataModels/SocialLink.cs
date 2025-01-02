using System.ComponentModel.DataAnnotations;

namespace NewProject.DataModels
{
    public class SocialLink
    {
        [Key]
        public int Id { get; set; }
        public string? SocialName { get; set; }
        public string? lLink { get; set; }
        public string? SocialIcon { get; set; }
    }
}
