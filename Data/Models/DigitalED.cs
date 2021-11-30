using Microsoft.EntityFrameworkCore;

namespace DigitalEdu.Data.Models
{
    public class DigitalEDContext : DbContext
    {
        public DigitalEDContext(DbContextOptions<DigitalEDContext> opt) : base(opt)
        {

        }

        public DbSet<PersonModel> Person { get; set; }

    }


}
