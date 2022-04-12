using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HackneyBookingsAPI.Migrations
{
    public partial class payment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymentDetails_BillingAddress",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "PaymentDetails_CVC",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "PaymentDetails_CardNumber",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "PaymentDetails_CardType",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "PaymentDetails_CardholderName",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "PaymentDetails_ExpiryDate",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "PaymentDetails_PaymentDetailsId",
                table: "Bookings");

            migrationBuilder.CreateTable(
                name: "PaymentDetails",
                columns: table => new
                {
                    BookingId = table.Column<int>(type: "integer", nullable: false),
                    PaymentDetailsId = table.Column<int>(type: "integer", nullable: false),
                    CardholderName = table.Column<string>(type: "text", nullable: false),
                    CardType = table.Column<string>(type: "text", nullable: false),
                    CardNumber = table.Column<int>(type: "integer", nullable: false),
                    BillingAddress = table.Column<string>(type: "text", nullable: false),
                    CVC = table.Column<int>(type: "integer", nullable: false),
                    ExpiryDate = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentDetails", x => x.BookingId);
                    table.ForeignKey(
                        name: "FK_PaymentDetails_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "BookingId",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaymentDetails");

            migrationBuilder.AddColumn<string>(
                name: "PaymentDetails_BillingAddress",
                table: "Bookings",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PaymentDetails_CVC",
                table: "Bookings",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PaymentDetails_CardNumber",
                table: "Bookings",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PaymentDetails_CardType",
                table: "Bookings",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PaymentDetails_CardholderName",
                table: "Bookings",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PaymentDetails_ExpiryDate",
                table: "Bookings",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PaymentDetails_PaymentDetailsId",
                table: "Bookings",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
