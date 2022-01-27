﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace FortnoxApiExample.Migrations
{
    public partial class New : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                "Token",
                table => new
                {
                    RealmId = table.Column<string>(maxLength: 50),
                    ScopeHash = table.Column<int>(),
                    AccessToken = table.Column<string>(maxLength: 1000),
                    RefreshToken = table.Column<string>(maxLength: 1000)
                },
                constraints: table => { table.PrimaryKey("PK_Token", x => x.RealmId); });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                "Token");
        }
    }
}