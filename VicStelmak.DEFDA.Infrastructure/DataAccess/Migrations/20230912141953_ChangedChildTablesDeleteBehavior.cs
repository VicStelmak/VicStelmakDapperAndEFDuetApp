using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VicStelmak.DEFDA.Infrastructure.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ChangedChildTablesDeleteBehavior : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Leaseholders_LeaseholderId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_EmailAddresses_Leaseholders_LeaseholderId",
                table: "EmailAddresses");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Leaseholders_LeaseholderId",
                table: "Addresses",
                column: "LeaseholderId",
                principalTable: "Leaseholders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmailAddresses_Leaseholders_LeaseholderId",
                table: "EmailAddresses",
                column: "LeaseholderId",
                principalTable: "Leaseholders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Leaseholders_LeaseholderId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_EmailAddresses_Leaseholders_LeaseholderId",
                table: "EmailAddresses");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Leaseholders_LeaseholderId",
                table: "Addresses",
                column: "LeaseholderId",
                principalTable: "Leaseholders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EmailAddresses_Leaseholders_LeaseholderId",
                table: "EmailAddresses",
                column: "LeaseholderId",
                principalTable: "Leaseholders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
