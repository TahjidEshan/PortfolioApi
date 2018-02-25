using Microsoft.EntityFrameworkCore;
using PortFolio2017.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortFolio2017.DAL
{
    public class PortfolioContext: DbContext
    {
        public PortfolioContext(DbContextOptions<PortfolioContext> options) : base(options)
        {

        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<GeneralSkill> GeneralSkills { get; set; }
        public DbSet<Header> Headers { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Motto> Mottos { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<SentMail> SentMails { get; set; }
        public DbSet<SocialService> SocialService { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publication> Publications { get; set; }
        public DbSet<PublicationAuthors> PublicationAuthors { get; set; }
        public DbSet<Work> WorkHistory { get; set; }
        public DbSet<Education> EducationHistory { get; set; }
    }
}
