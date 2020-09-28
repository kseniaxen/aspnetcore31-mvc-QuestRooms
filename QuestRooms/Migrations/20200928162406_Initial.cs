using Microsoft.EntityFrameworkCore.Migrations;

namespace QuestRooms.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QuestRooms",
                columns: table => new
                {
                    QuestRoomID = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Time = table.Column<string>(nullable: true),
                    MinimumPeople = table.Column<int>(nullable: false),
                    MaximumPeople = table.Column<int>(nullable: false),
                    MinimumAgePeople = table.Column<int>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Company = table.Column<string>(nullable: true),
                    Rating = table.Column<int>(nullable: false),
                    LevelFear = table.Column<int>(nullable: false),
                    LevelСomplexity = table.Column<int>(nullable: false),
                    Logo = table.Column<string>(nullable: true),
                    GalleryPhotos = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestRooms", x => x.QuestRoomID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuestRooms");
        }
    }
}
