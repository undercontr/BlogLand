using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class addusertopost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Users_AppUserId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "AccessFailedCount",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LockoutEnabled",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LockoutEnd",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Users",
                newName: "Username");

            migrationBuilder.RenameColumn(
                name: "TwoFactorEnabled",
                table: "Users",
                newName: "IsDeleted");

            migrationBuilder.RenameColumn(
                name: "SecurityStamp",
                table: "Users",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "PhoneNumberConfirmed",
                table: "Users",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "PasswordHash",
                table: "Users",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "NormalizedUserName",
                table: "Users",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "NormalizedEmail",
                table: "Users",
                newName: "ConfirmPassword");

            migrationBuilder.RenameColumn(
                name: "AppUserId",
                table: "Posts",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_AppUserId",
                table: "Posts",
                newName: "IX_Posts_UserId");

            migrationBuilder.AlterColumn<string>(
                name: "EmailConfirmed",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedOn",
                table: "Users",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Users_UserId",
                table: "Posts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Users_UserId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Users",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Users",
                newName: "SecurityStamp");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Users",
                newName: "PasswordHash");

            migrationBuilder.RenameColumn(
                name: "IsDeleted",
                table: "Users",
                newName: "TwoFactorEnabled");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Users",
                newName: "PhoneNumberConfirmed");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Users",
                newName: "NormalizedUserName");

            migrationBuilder.RenameColumn(
                name: "ConfirmPassword",
                table: "Users",
                newName: "NormalizedEmail");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Posts",
                newName: "AppUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_UserId",
                table: "Posts",
                newName: "IX_Posts_AppUserId");

            migrationBuilder.AlterColumn<bool>(
                name: "EmailConfirmed",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccessFailedCount",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "LockoutEnabled",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "LockoutEnd",
                table: "Users",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Users_AppUserId",
                table: "Posts",
                column: "AppUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
