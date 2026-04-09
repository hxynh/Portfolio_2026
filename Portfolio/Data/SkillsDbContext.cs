using System;
using Microsoft.EntityFrameworkCore;
using Portfolio.Models;

namespace Portfolio.Data;

public class SkillsDbContext(DbContextOptions<SkillsDbContext> options) : DbContext(options)
{
    public DbSet<SkillsList> SkillsLists { get; set; }

     protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<SkillsList>().HasData(
            new SkillsList { Id = 1, Category = "Backend", Name = "C#" },
            new SkillsList { Id = 2, Category = "Backend", Name = "JavaScript" },
            new SkillsList { Id = 3, Category = "Backend", Name = "TypeScript" },
            new SkillsList { Id = 4, Category = "Backend", Name = "Python" },
            new SkillsList { Id = 5, Category = "Backend", Name = "C/C++" },
            new SkillsList { Id = 6, Category = "Backend", Name = "SQL" },

            new SkillsList { Id = 7, Category = "Frontend", Name = "Angular" },
            new SkillsList { Id = 8, Category = "Frontend", Name = "React" },
            new SkillsList { Id = 9, Category = "Frontend", Name = "HTML" },
            new SkillsList { Id = 10, Category = "Frontend", Name = "CSS/Tailwind CSS" },
            new SkillsList { Id = 11, Category = "Frontend", Name = "Material UI/Bootstrap/Font Awesome" },

            new SkillsList { Id = 12, Category = "Tools", Name = "Version Control - Git" },
            new SkillsList { Id = 13, Category = "Tools", Name = "Figma" },
            new SkillsList { Id = 14, Category = "Tools", Name = "Postman" },
            new SkillsList { Id = 15, Category = "Tools", Name = "Playwright" }


        );

    }
}
