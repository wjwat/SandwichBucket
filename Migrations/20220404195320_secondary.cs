using Microsoft.EntityFrameworkCore.Migrations;

namespace SandwichBucket.Migrations
{
    public partial class secondary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 34);

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 1,
                column: "Alignment",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 2,
                column: "Alignment",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 4,
                column: "Alignment",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 5,
                column: "Alignment",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 6,
                column: "Alignment",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 7,
                column: "Alignment",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 8,
                column: "Alignment",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 10,
                column: "Alignment",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 11,
                column: "Alignment",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 12,
                column: "Alignment",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 13,
                column: "Alignment",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 14,
                column: "Alignment",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 15,
                column: "Alignment",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 16,
                column: "Alignment",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 17,
                column: "Alignment",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 18,
                column: "Alignment",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 19,
                column: "Alignment",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 20,
                column: "Alignment",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 21,
                column: "Alignment",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 22,
                column: "Alignment",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 23,
                column: "Alignment",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 24,
                column: "Alignment",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 25,
                column: "Alignment",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 27,
                column: "Alignment",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 28,
                column: "Alignment",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 29,
                column: "Alignment",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 30,
                columns: new[] { "Alignment", "Description", "Name" },
                values: new object[] { 8, "yum", "Torta" });

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 31,
                columns: new[] { "Alignment", "Description", "Name" },
                values: new object[] { 2, "Chicken of the sea", "Tuna Salad" });

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 32,
                columns: new[] { "Alignment", "Description", "Name" },
                values: new object[] { 2, "Some dirt between two 2 x 4s", "Wood" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 1,
                column: "Alignment",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 2,
                column: "Alignment",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 4,
                column: "Alignment",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 5,
                column: "Alignment",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 6,
                column: "Alignment",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 7,
                column: "Alignment",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 8,
                column: "Alignment",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 10,
                column: "Alignment",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 11,
                column: "Alignment",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 12,
                column: "Alignment",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 13,
                column: "Alignment",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 14,
                column: "Alignment",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 15,
                column: "Alignment",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 16,
                column: "Alignment",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 17,
                column: "Alignment",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 18,
                column: "Alignment",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 19,
                column: "Alignment",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 20,
                column: "Alignment",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 21,
                column: "Alignment",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 22,
                column: "Alignment",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 23,
                column: "Alignment",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 24,
                column: "Alignment",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 25,
                column: "Alignment",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 27,
                column: "Alignment",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 28,
                column: "Alignment",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 29,
                column: "Alignment",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 30,
                columns: new[] { "Alignment", "Description", "Name" },
                values: new object[] { 0, "Maybe the best of all sandwiches", "Taco" });

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 31,
                columns: new[] { "Alignment", "Description", "Name" },
                values: new object[] { 0, "yum", "Torta" });

            migrationBuilder.UpdateData(
                table: "Sandwiches",
                keyColumn: "SandwichId",
                keyValue: 32,
                columns: new[] { "Alignment", "Description", "Name" },
                values: new object[] { 0, "Chicken of the sea", "Tuna Salad" });

            migrationBuilder.InsertData(
                table: "Sandwiches",
                columns: new[] { "SandwichId", "Alignment", "Description", "Name" },
                values: new object[,]
                {
                    { 34, 0, "Some dirt between two 2 x 4s", "Wood" },
                    { 33, 0, "Chicken of the sea", "Tuna Salad" }
                });
        }
    }
}
