using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AdminService.Migrations
{
    public partial class TableNameChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_Posts_SystemUserUserID",
                table: "Blogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Posts",
                table: "Posts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Blogs",
                table: "Blogs");

            migrationBuilder.RenameTable(
                name: "Posts",
                newName: "SystemUsers");

            migrationBuilder.RenameTable(
                name: "Blogs",
                newName: "Customers");

            migrationBuilder.RenameIndex(
                name: "IX_Blogs_SystemUserUserID",
                table: "Customers",
                newName: "IX_Customers_SystemUserUserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SystemUsers",
                table: "SystemUsers",
                column: "UserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_SystemUsers_SystemUserUserID",
                table: "Customers",
                column: "SystemUserUserID",
                principalTable: "SystemUsers",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_SystemUsers_SystemUserUserID",
                table: "Customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SystemUsers",
                table: "SystemUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.RenameTable(
                name: "SystemUsers",
                newName: "Posts");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "Blogs");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_SystemUserUserID",
                table: "Blogs",
                newName: "IX_Blogs_SystemUserUserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Posts",
                table: "Posts",
                column: "UserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Blogs",
                table: "Blogs",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_Posts_SystemUserUserID",
                table: "Blogs",
                column: "SystemUserUserID",
                principalTable: "Posts",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
