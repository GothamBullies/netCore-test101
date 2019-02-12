using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using test_Project.Data.Models;
using test_Project.Data;

namespace test_Project.Data
{
    public class test_ProjectDbContext : IdentityDbContext
    {
        public test_ProjectDbContext(DbContextOptions<test_ProjectDbContext> options)
            : base(options)
        {
        } 

        public test_ProjectDbContext()
        {
        } 

        public DbSet<BlogsModel> Blogs { get; set; } 
      
        public DbSet<VideosModel> Videos { get; set; }

        public DbSet<NewsModel> News { get; set; } 
        public DbSet<WebcastsModel> Webcasts { get; set; }
        public DbSet<ZipCodesModel> ZipCodes  { get; set; }
        public DbSet<ConferenceModel> Conferences { get;set; }
        public DbSet<FloorPlansModel> FloorPlans {get; set; }

    }
}
