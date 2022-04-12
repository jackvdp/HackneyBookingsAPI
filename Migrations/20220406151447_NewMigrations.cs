using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace HackneyBookingsAPI.Migrations
{
    public partial class NewMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Locations_LocationId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Categories_CategoryId",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentDetails_Bookings_BookingId",
                table: "PaymentDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Slots_Bookings_BookingId",
                table: "Slots");

            migrationBuilder.DropIndex(
                name: "IX_Slots_BookingId",
                table: "Slots");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PaymentDetails",
                table: "PaymentDetails");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_LocationId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "Field",
                table: "Slots");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Bookings");

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "Slots",
                type: "integer",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PaymentDetailsId",
                table: "PaymentDetails",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<string>(
                name: "ExpiryDate",
                table: "PaymentDetails",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "CardholderName",
                table: "PaymentDetails",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "CardType",
                table: "PaymentDetails",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "BillingAddress",
                table: "PaymentDetails",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "BookingId",
                table: "PaymentDetails",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Locations",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Locations",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Locations",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Bookings",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Bookings",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Bookings",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "BookingReference",
                table: "Bookings",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<int>(
                name: "SlotId",
                table: "Bookings",
                type: "integer",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaymentDetails",
                table: "PaymentDetails",
                column: "PaymentDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_Slots_LocationId",
                table: "Slots",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentDetails_BookingId",
                table: "PaymentDetails",
                column: "BookingId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_SlotId",
                table: "Bookings",
                column: "SlotId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Slots_SlotId",
                table: "Bookings",
                column: "SlotId",
                principalTable: "Slots",
                principalColumn: "SlotId");

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Categories_CategoryId",
                table: "Locations",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentDetails_Bookings_BookingId",
                table: "PaymentDetails",
                column: "BookingId",
                principalTable: "Bookings",
                principalColumn: "BookingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Slots_Locations_LocationId",
                table: "Slots",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "LocationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Slots_SlotId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Categories_CategoryId",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentDetails_Bookings_BookingId",
                table: "PaymentDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Slots_Locations_LocationId",
                table: "Slots");

            migrationBuilder.DropIndex(
                name: "IX_Slots_LocationId",
                table: "Slots");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PaymentDetails",
                table: "PaymentDetails");

            migrationBuilder.DropIndex(
                name: "IX_PaymentDetails_BookingId",
                table: "PaymentDetails");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_SlotId",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Slots");

            migrationBuilder.DropColumn(
                name: "SlotId",
                table: "Bookings");

            migrationBuilder.AddColumn<string>(
                name: "Field",
                table: "Slots",
                type: "text",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ExpiryDate",
                table: "PaymentDetails",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CardholderName",
                table: "PaymentDetails",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CardType",
                table: "PaymentDetails",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BookingId",
                table: "PaymentDetails",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BillingAddress",
                table: "PaymentDetails",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PaymentDetailsId",
                table: "PaymentDetails",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Locations",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Locations",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Locations",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Bookings",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Bookings",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Bookings",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BookingReference",
                table: "Bookings",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "Bookings",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaymentDetails",
                table: "PaymentDetails",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_Slots_BookingId",
                table: "Slots",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_LocationId",
                table: "Bookings",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Locations_LocationId",
                table: "Bookings",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Categories_CategoryId",
                table: "Locations",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentDetails_Bookings_BookingId",
                table: "PaymentDetails",
                column: "BookingId",
                principalTable: "Bookings",
                principalColumn: "BookingId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Slots_Bookings_BookingId",
                table: "Slots",
                column: "BookingId",
                principalTable: "Bookings",
                principalColumn: "BookingId");
        }
    }
}
