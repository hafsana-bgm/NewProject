using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NewProject.Migrations
{
    /// <inheritdoc />
    public partial class Social_v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SocialMedias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SocialName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    socialLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SocialIcon = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMedias", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SocialMedias");
        }
    }
}
