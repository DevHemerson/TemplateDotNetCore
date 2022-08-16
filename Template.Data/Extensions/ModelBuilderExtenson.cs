using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Domain.Entities;

namespace Template.Data.Extensions
{
    public static class ModelBuilderExtenson
    {
        public static ModelBuilder SeedData(this ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasData(
                    new User { Id = Guid.Parse("93504763-7f04-43e0-b3db-f6bb7f14d2ae") , Name = "User Default", Email = "userdefault@template.com", DateCreated = new DateTime (2020,2,2), IsDeleted = false, DateUpdated = null }
                );

            return builder;
        }
    }
}
