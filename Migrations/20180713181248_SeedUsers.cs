using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace difpediaProject.Migrations
{
    public partial class SeedUsers : Migration
    {
         protected override void Up(MigrationBuilder migrationBuilder)
        {
              migrationBuilder.Sql("INSERT INTO Users (Name, Role, Password, ReferalUserId, Balance) VALUES ('Saviya', 'ContentManager','qwert12345', 0, 0)");
              migrationBuilder.Sql("INSERT INTO Users (Name, Role, Password, ReferalUserId, Balance) VALUES ('Kajal', 'ImageManager','qwert12345', 0, 0)");
              migrationBuilder.Sql("INSERT INTO Users (Name, Role, Password, ReferalUserId, Balance) VALUES ('Joydeep', 'VideoManager','qwert12345', 0, 0)");

        }


        protected override void Down(MigrationBuilder migrationBuilder)
        {
             migrationBuilder.Sql("DELETE FROM Users");
        }
    }
}
