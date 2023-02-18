using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Alpaca.Tool.WebAPI.First.Migrations
{
    public partial class M_Member : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "M_Member",
                columns: table => new
                {
                    MemberID = table.Column<int>(type: "int", nullable: false),
                    MemberName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MemberNameKana = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MemberNameEng = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageColorID = table.Column<int>(type: "int", nullable: true),
                    Grade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<short>(type: "smallint", nullable: true),
                    BirthDay = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Height = table.Column<int>(type: "int", nullable: true),
                    BloodType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bust = table.Column<int>(type: "int", nullable: true),
                    Waist = table.Column<int>(type: "int", nullable: true),
                    Hip = table.Column<int>(type: "int", nullable: true),
                    Detail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Invalid_FLG = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_Member", x => x.MemberID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "M_Member");
        }
    }
}
