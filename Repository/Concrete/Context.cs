using Batu.Entites.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batu.Repository.Concrete
{
  public  class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder) {
            //TODO :DI connectring config string yap buraya ordan ver 
            dbContextOptionsBuilder.UseSqlServer("Server=BATU;Database=ASPCoreLearn;Trusted_Connection=True;");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<ContactEntity> Contacts { get; set; }
        public DbSet<ExperienceEntity> Experiences { get; set; }
        public DbSet<MainPage> MainPagesTables { get; set; }
        public DbSet<PortfolioEntity> Portfolios { get; set; }
        public DbSet<ServiceEntity> Services { get; set; }
        public DbSet<SkillEntity> Skills { get; set; }
        public DbSet<SocialMediaEntity> SocialMedias { get; set; }
        public DbSet<TestimonialEntity> Testimonials { get; set; }




    }
}
