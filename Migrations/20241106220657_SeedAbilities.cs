using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace W9_assignment_template.Migrations
{
    public partial class SeedAbilities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Enable identity insert for Rooms
            migrationBuilder.Sql("SET IDENTITY_INSERT Abilities ON");

            // Insert Rooms
            migrationBuilder.Sql("INSERT INTO Abilities (Id, Name, Description, Discriminator, Taunt) VALUES (1, 'Flashbang', 'Pull the pin and throw. It will blind all the enemies','Player', 1)");
            migrationBuilder.Sql("INSERT INTO Abilities (Id, Name, Description, Discriminator, Shove) VALUES (2, 'Explode', 'Literally just explodes the enemy','Player', 1)");
            migrationBuilder.Sql("INSERT INTO Abilities (Id, Name, Description, Discriminator, Taunt) VALUES (3, 'Yell', 'A yell to gain attention','Goblin', 1)");
            // Disable identity insert for Rooms
            migrationBuilder.Sql("SET IDENTITY_INSERT Abilities OFF");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
