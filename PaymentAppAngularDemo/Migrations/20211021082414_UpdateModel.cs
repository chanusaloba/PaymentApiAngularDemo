using Microsoft.EntityFrameworkCore.Migrations;

namespace PaymentAppAngularDemo.Migrations
{
    public partial class UpdateModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SecurityCode",
                table: "PaymentDetails",
                type: "nvarchar(3)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)");

            migrationBuilder.AlterColumn<string>(
                name: "ExpirationDate",
                table: "PaymentDetails",
                type: "nvarchar(5)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(5)");

            migrationBuilder.AlterColumn<string>(
                name: "CardOwnerName",
                table: "PaymentDetails",
                type: "nvarchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "CardNumber",
                table: "PaymentDetails",
                type: "nvarchar(16)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(16)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SecurityCode",
                table: "PaymentDetails",
                type: "nvarchar(3)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ExpirationDate",
                table: "PaymentDetails",
                type: "nvarchar(5)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(5)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CardOwnerName",
                table: "PaymentDetails",
                type: "nvarchar(100)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CardNumber",
                table: "PaymentDetails",
                type: "nvarchar(16)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(16)",
                oldNullable: true);
        }
    }
}
