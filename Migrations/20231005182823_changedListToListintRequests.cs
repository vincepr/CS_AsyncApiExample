using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AsyncApiExample.Migrations
{
    /// <inheritdoc />
    public partial class changedListToListintRequests : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_List",
                table: "List");

            migrationBuilder.RenameTable(
                name: "List",
                newName: "ListingRequests");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ListingRequests",
                table: "ListingRequests",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ListingRequests",
                table: "ListingRequests");

            migrationBuilder.RenameTable(
                name: "ListingRequests",
                newName: "List");

            migrationBuilder.AddPrimaryKey(
                name: "PK_List",
                table: "List",
                column: "Id");
        }
    }
}
