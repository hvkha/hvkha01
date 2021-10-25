using Microsoft.EntityFrameworkCore.Migrations;

namespace AnPhuocShop.Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnPhuocs",
                columns: table => new
                {
                    AnPhuocId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tensp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hoatiet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Thongtin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoaispId = table.Column<int>(type: "int", nullable: false),
                    Hinhanh = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnPhuocs", x => x.AnPhuocId);
                });

            migrationBuilder.CreateTable(
                name: "Loaisps",
                columns: table => new
                {
                    LoaispId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoaispName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loaisps", x => x.LoaispId);
                });

            migrationBuilder.InsertData(
                table: "AnPhuocs",
                columns: new[] { "AnPhuocId", "Gia", "Hinhanh", "Hoatiet", "LoaispId", "Tensp", "Thongtin" },
                values: new object[,]
                {
                    { 1, "905.000 đ", "image/ASN002182.jpg", "Trơn", 1, "Áo Sơ mi Nam ngắn tay An Phước - ASN002182", "Miễn phí vận chuyển cho đơn hàng từ 1.000.000đ\nChính sách đổi hàng:\n- Quần, áo: Được đổi hàng trong vòng 30 ngày kể từ ngày mua.\n- Giày dép, áo len: Được đổi hàng trong vòng 07 ngày kể từ ngày mua.\n- Phụ kiện (thắt lưng, ví, túi xách): Không được đổi trả, được bảo hành trong vòng 60 ngày." },
                    { 2, "1.418.000 đ", "image/PTH000268.jpg", "Trơn", 2, "Áo Thun Nam tay ngắn Pierre Cardin - PTH000268", "Miễn phí vận chuyển cho đơn hàng từ 1.000.000đ\nChính sách đổi hàng:\n- Quần, áo: Được đổi hàng trong vòng 30 ngày kể từ ngày mua.\n- Giày dép, áo len: Được đổi hàng trong vòng 07 ngày kể từ ngày mua.\n- Phụ kiện (thắt lưng, ví, túi xách): Không được đổi trả, được bảo hành trong vòng 60 ngày." },
                    { 3, "668.000 đ", "image/ASN002225.jpg", "Bông", 3, "Áo Sơ mi Nam ngắn tay An Phước - ASN002225", "Miễn phí vận chuyển cho đơn hàng từ 1.000.000đ\nChính sách đổi hàng:\n- Quần, áo: Được đổi hàng trong vòng 30 ngày kể từ ngày mua.\n- Giày dép, áo len: Được đổi hàng trong vòng 07 ngày kể từ ngày mua.\n- Phụ kiện (thắt lưng, ví, túi xách): Không được đổi trả, được bảo hành trong vòng 60 ngày." },
                    { 4, "928.000 đ", "image/AJKN00103.jpg", "Bông", 4, "Áo Jacket Nữ An Phước - AJKN00103", "Miễn phí vận chuyển cho đơn hàng từ 1.000.000đ\nChính sách đổi hàng:\n- Quần, áo: Được đổi hàng trong vòng 30 ngày kể từ ngày mua.\n- Giày dép, áo len: Được đổi hàng trong vòng 07 ngày kể từ ngày mua.\n- Phụ kiện (thắt lưng, ví, túi xách): Không được đổi trả, được bảo hành trong vòng 60 ngày." }
                });

            migrationBuilder.InsertData(
                table: "Loaisps",
                columns: new[] { "LoaispId", "LoaispName" },
                values: new object[,]
                {
                    { 1, "Áo Sơ mi Nam" },
                    { 2, "Áo Thun Nam" },
                    { 3, "Áo Sơ mi Nam" },
                    { 4, "Áo Jacket Nữ" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnPhuocs");

            migrationBuilder.DropTable(
                name: "Loaisps");
        }
    }
}
