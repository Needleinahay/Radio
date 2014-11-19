using System.Data.Entity;
using Models;
namespace Data_layer
{
    public class RadioContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<ProducerInfo> ProducerInfos { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<RateRules> RateRuleses { get; set; }

    }
}
