using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventManagement.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WeddingFunction = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthdayTheme = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    package = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    venue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VenueType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpecifyLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    guests = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    catering = table.Column<bool>(type: "bit", nullable: false),
                    decoration = table.Column<bool>(type: "bit", nullable: false),
                    photography = table.Column<bool>(type: "bit", nullable: false),
                    music = table.Column<bool>(type: "bit", nullable: false),
                    venu = table.Column<bool>(type: "bit", nullable: false),
                    textare = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    newsletter = table.Column<bool>(type: "bit", nullable: false),
                    privacyy = table.Column<bool>(type: "bit", nullable: false),
                    SuccessMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ErrorMessage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
