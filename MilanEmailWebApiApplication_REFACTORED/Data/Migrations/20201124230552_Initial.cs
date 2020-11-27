using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(maxLength: 50, nullable: true),
                    LastName = table.Column<string>(maxLength: 50, nullable: true),
                    UserName = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Emails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Text = table.Column<string>(maxLength: 400, nullable: false),
                    Headline = table.Column<string>(nullable: true),
                    Category = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Emails_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FirstName", "LastName", "Password", "UserName" },
                values: new object[] { 1, "Steve", "Stevenson", "12345", "steve123" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FirstName", "LastName", "Password", "UserName" },
                values: new object[] { 2, "Robert", "Robertson", "67890", "R.R" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FirstName", "LastName", "Password", "UserName" },
                values: new object[] { 3, "James", "Jameson", "123456", "James" });

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "Id", "Category", "Headline", "Text", "UserId" },
                values: new object[,]
                {
                    { 1, 3, "Corona Virus Business Update", "Check out our new blog post regarding the newest changes in business due to the global pandemic", 1 },
                    { 2, 3, "New Investment opportunities", "Explore the newest investment opportunities", 1 },
                    { 4, 4, "Chores", "Do the dishes, laundry and buy groceries", 1 },
                    { 6, 1, "Learn Angular", "Learn through various books and official documentation", 1 },
                    { 3, 4, "Doctor appointment", "Don't forget about your upcoming medical appointment ", 2 },
                    { 5, 2, "Upcoming Meeting", "New Work Meeting related to quarterly results", 2 },
                    { 7, 1, "Learn ASP.NET Core Web APi", "Read books, watch tutorials and follow documentation", 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Emails_UserId",
                table: "Emails",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Emails");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
