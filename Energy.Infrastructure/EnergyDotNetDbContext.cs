﻿using Microsoft.EntityFrameworkCore;

namespace Energy.Infrastructure
{
    public class EnergyDotNetDbContext : DbContext
    {
        public EnergyDotNetDbContext(DbContextOptions options)
            : base(options)
        {
        }

    }
}
