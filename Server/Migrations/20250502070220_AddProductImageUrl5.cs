using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Server.Migrations
{
    /// <inheritdoc />
    public partial class AddProductImageUrl5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Category", "ImageUrl", "Name", "Price" },
                values: new object[] { "Books", "https://images.unsplash.com/photo-1553729784-e91953dec042", "Book: ReactJS Guide", 30 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Category", "ImageUrl", "Name", "Price" },
                values: new object[] { "Books", "https://images.unsplash.com/photo-1524995997946-a1c2e315a42f", "Book: JavaScript Mastery", 25 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Category", "ImageUrl", "Name", "Price" },
                values: new object[] { "Groceries", "https://images.unsplash.com/photo-1623271270835-98ee6b0fd5c9", "Sugar (1kg)", 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Category", "ImageUrl", "Name", "Price" },
                values: new object[] { "Groceries", "https://images.unsplash.com/photo-1597953689321-0b24b9c0d86b", "Flour (1kg)", 1 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 16, "Groceries", "https://images.unsplash.com/photo-1621517682370-df6c4470f80d", "Vegetable Oil (500ml)", 3 },
                    { 17, "Books", "https://images.unsplash.com/photo-1553729784-e91953dec042", "Book: ReactJS Guide", 30 },
                    { 18, "Books", "https://images.unsplash.com/photo-1524995997946-a1c2e315a42f", "Book: JavaScript Mastery", 25 },
                    { 19, "Furniture", "https://images.unsplash.com/photo-1618531971792-e79d99987217", "Sofa", 400 },
                    { 20, "Furniture", "https://images.unsplash.com/photo-1603317657060-3ca2069ecb0b", "Dining Table", 250 }
                });
        }
    }
}
