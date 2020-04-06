﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Panda.Domain;
using System;

namespace Panda.Data
{
    public class PandaDbContext : IdentityDbContext<PandaUser>
    {
        public DbSet<Package> Packages { get; set; }
        public PandaDbContext(DbContextOptions<PandaDbContext> options)
            :base(options)
        {

        }

   
    }
}
