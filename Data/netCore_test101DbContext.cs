using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using netCore_test101.Data;
using netCore_test101.Data.Models;

namespace netCore_test101.Data
{
    public class netCore_test101DbContext : IdentityDbContext
    {
        public netCore_test101DbContext(DbContextOptions<netCore_test101DbContext> options)
            : base(options)
        {
        } 

        public netCore_test101DbContext()
        {
        } 
       public DbSet<BlogsModel> Blogs { get; set; } 
        public DbSet<NewsModel> News { get; set; } 
        public DbSet<VideosModel> Videos { get; set; }
        public DbSet<ConferenceModel> Conferences { get; set; }
        public DbSet<MediaProfilesModel> MediaProfiles { get; set; }
        public DbSet<PressReleasesModel> PressReleases { get; set; }
        public DbSet<UsageModel> Usage { get; set; }
        public DbSet<UsagePagesModel> UsagePages { get; set; }
        public DbSet<VendorCategoriesModel> VendorCategories { get; set; }
        public DbSet<VendorsModel> Vendors { get; set; }
        public DbSet<WebcastsModel> Webcasts { get; set; }
        public DbSet<ZipCodesModel> ZipCodes { get; set; }
        public DbSet<UserDetailsModel> UserDetails { get; set; }
        public DbSet<PropertiesModel> Properties { get; set; }
        public DbSet<FloorPlansModel> FloorPlans { get; set; }

    }
}
