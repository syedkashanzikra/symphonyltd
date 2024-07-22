﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SymphonyLtd.Migrations
{
    /// <inheritdoc />
    public partial class nayakaam : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Grade",
                table: "tblStudents",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Grade",
                table: "tblStudents");
        }
    }
}
