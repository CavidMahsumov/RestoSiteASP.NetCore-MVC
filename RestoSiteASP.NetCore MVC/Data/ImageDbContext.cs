using Microsoft.EntityFrameworkCore;
using RestoSiteASP.NetCore_MVC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestoSiteASP.NetCore_MVC.Data 
{
    public class ImageDbContext:DbContext
    {
        public ImageDbContext(DbContextOptions<ImageDbContext>options)
            :base(options)
        {

        }
        public DbSet<Image>Images { get; set; }
    }
}
