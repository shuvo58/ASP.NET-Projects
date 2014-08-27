using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebMdApp_02.Models
{
    public class AppContext:DbContext
    {
        public DbSet<Doctor> Doctors { set; get; }
        public DbSet<Article> Articles { set; get; }
    }
}