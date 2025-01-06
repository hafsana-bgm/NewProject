using Microsoft.EntityFrameworkCore;
using NewProject.DataDatamodels;
using NewProject.DataModels;

namespace NewProject.Data
{
  public class NewProjectContext : DbContext
    {
        public NewProjectContext(DbContextOptions<NewProjectContext> options) : base(options)
        { 
        
        }

        public DbSet<Contact> Contact { get; set; } = default!;
      
        public DbSet<Books> Books { get; set; } = default!;

        public DbSet<Blog> Blog { get; set; } = default!;

        public DbSet<SocialLink> SocialLink { get; set; } = default!;

        public DbSet<ContactUs> Contactus { get; set; } = default!;

        public DbSet<Shop> Shops { get; set; } = default!;



    }

}
