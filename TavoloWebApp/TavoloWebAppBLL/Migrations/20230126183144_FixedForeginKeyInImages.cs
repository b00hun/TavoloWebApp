using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TavoloWebAppBll.Migrations
{
    public partial class FixedForeginKeyInImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Projects_ProjectId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_ProjectId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Images");

            migrationBuilder.CreateIndex(
                name: "IX_Images_Project_Id",
                table: "Images",
                column: "Project_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Projects_Project_Id",
                table: "Images",
                column: "Project_Id",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Projects_Project_Id",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_Project_Id",
                table: "Images");

            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "Images",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Images_ProjectId",
                table: "Images",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Projects_ProjectId",
                table: "Images",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
