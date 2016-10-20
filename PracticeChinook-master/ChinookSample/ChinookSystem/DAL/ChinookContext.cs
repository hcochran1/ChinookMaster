﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.Data.Entity;   //allows use of dbcontext
using ChinookSystem.Data.Entities;
#endregion

namespace ChinookSystem.DAL
{
    //internal for security reasons
    //access restricted to within component library
    //inherit DbContext for Entity Framework requires System.Data.Entity 
    internal class ChinookContext : DbContext
    {
        //pass the connection string name to the DbContext using :base()
       public ChinookContext(): base("ChinookDB")
        {

        }
        //setup DbSet properties
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<MediaType> MediaTypes { get; set; }
    }
}
