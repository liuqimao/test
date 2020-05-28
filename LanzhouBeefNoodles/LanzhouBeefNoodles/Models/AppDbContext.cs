﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace LanzhouBeefNoodles.Models
{
    public class AppDbContext:IdentityDbContext<IdentityUser>
    {

        public AppDbContext(DbContextOptions<AppDbContext>options)
            :base(options)
        {

        }

        public DbSet<Noodle> Noodles { set; get; }
        public DbSet<Feedback> Feedbacks { get; set; }


    }
}
