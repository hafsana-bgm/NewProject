using System.ComponentModel.DataAnnotations;

namespace NewProject.DataDatamodels
{
    public class SocialMedia
    {

        [Key]
        public int Id { get; set; }
        public string? SocialName { get; set; }
        public string? socialLink { get; set; }
        public string? SocialIcon { get; set; }
    }
}
