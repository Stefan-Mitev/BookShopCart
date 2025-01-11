﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookShopCartMvcUi.Migrations
{
    /// <inheritdoc />
    public partial class addauthornametobook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AuthorName",
                table: "Book",
                type: "varchar(40)",
                maxLength: 40,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AuthorName",
                table: "Book");
        }
    }
}
