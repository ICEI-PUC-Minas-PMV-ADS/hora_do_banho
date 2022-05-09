using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HoraDoBanho.Data.Migrations
{
    public partial class Login : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Login",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login", x => x.id);
                });


            string[] columns = { "userName", "password" };
            string[] values = { "crislaine.silva@sga.pucminas.br", "e10adc3949ba59abbe56e057f20f883e" }; //SENHA 123456 Criptografada
            migrationBuilder.InsertData(table: "Login", columns, values);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Login");
        }
    }
}
