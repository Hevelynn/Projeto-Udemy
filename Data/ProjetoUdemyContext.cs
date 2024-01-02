﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoUdemy.Models;

namespace ProjetoUdemy.Data
{
    public class ProjetoUdemyContext : DbContext
    {
        public ProjetoUdemyContext (DbContextOptions<ProjetoUdemyContext> options)
            : base(options)
        {

        }

        public DbSet<ProjetoUdemy.Models.Department> Department { get; set; } = default!;
    }
}
