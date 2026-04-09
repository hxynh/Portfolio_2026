using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Portfolio.Migrations
{
    /// <inheritdoc />
    public partial class AddSkillsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SkillsLists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillsLists", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "SkillsLists",
                columns: new[] { "Id", "Category", "Name" },
                values: new object[,]
                {
                    { 1, "Backend", "C#" },
                    { 2, "Backend", "JavaScript" },
                    { 3, "Backend", "TypeScript" },
                    { 4, "Backend", "Python" },
                    { 5, "Backend", "C/C++" },
                    { 6, "Backend", "SQL" },
                    { 7, "Frontend", "Angular" },
                    { 8, "Frontend", "React" },
                    { 9, "Frontend", "HTML" },
                    { 10, "Frontend", "CSS/Tailwind CSS" },
                    { 11, "Frontend", "Material UI/Bootstrap/Font Awesome" },
                    { 12, "Tools", "Version Control - Git" },
                    { 13, "Tools", "Figma" },
                    { 14, "Tools", "Postman" },
                    { 15, "Tools", "Playwright" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SkillsLists");
        }
    }
}
