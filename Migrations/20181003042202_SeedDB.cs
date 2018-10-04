using Microsoft.EntityFrameworkCore.Migrations;

namespace Test.Migrations
{
    public partial class SeedDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Audi')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Honda')");
            migrationBuilder.Sql("INSERT INTO Makes (Name) VALUES ('Toyota')");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Audi-ModelA', (SELECT ID FROM Makes WHERE Name = 'Audi'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Audi-ModelB', (SELECT ID FROM Makes WHERE Name = 'Audi'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Audi-ModelC', (SELECT ID FROM Makes WHERE Name = 'Audi'))");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Honda-ModelA', (SELECT ID FROM Makes WHERE Name = 'Honda'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Honda-ModelB', (SELECT ID FROM Makes WHERE Name = 'Honda'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Honda-ModelC', (SELECT ID FROM Makes WHERE Name = 'Honda'))");

            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Toyota-ModelA', (SELECT ID FROM Makes WHERE Name = 'Toyota'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Toyota-ModelB', (SELECT ID FROM Makes WHERE Name = 'Toyota'))");
            migrationBuilder.Sql("INSERT INTO Models (Name, MakeID) VALUES ('Toyota-ModelC', (SELECT ID FROM Makes WHERE Name = 'Toyota'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Makes WHERE Name IN ('Audi', 'Honda', 'Toyota')");
        }
    }
}
