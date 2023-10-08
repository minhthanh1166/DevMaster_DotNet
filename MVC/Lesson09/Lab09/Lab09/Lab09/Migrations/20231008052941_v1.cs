using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab09.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ADMIN_LOG",
                columns: table => new
                {
                    LOG_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    STATUS = table.Column<int>(type: "int", nullable: true),
                    SESSION_ID = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    APP_CODE = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    THREAD_ID = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    START_TIME = table.Column<DateTime>(type: "datetime", nullable: true),
                    END_TIME = table.Column<DateTime>(type: "datetime", nullable: true),
                    ADMIN_USER_ID = table.Column<int>(type: "int", nullable: true),
                    USER_LOGIN = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    USER_NAME = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    IP_ADDRESS = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ACTION_CODE = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    ACTION_NAME = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    MENU_CODE = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    MENU_NAME = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    WEBPAGES_ACTION_ID = table.Column<int>(type: "int", nullable: true),
                    ACTION_TYPE = table.Column<int>(type: "int", nullable: true),
                    OBJECT_ID = table.Column<int>(type: "int", nullable: true),
                    CONTENT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DESCRIPTION = table.Column<string>(type: "nvarchar(550)", maxLength: 550, nullable: true),
                    LOG_LEVEL = table.Column<int>(type: "int", nullable: true),
                    ERROR_CODE = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ADMIN_LO__4364C8822A822E87", x => x.LOG_ID);
                });

            migrationBuilder.CreateTable(
                name: "ADMIN_USER",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ACCOUNT = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    PASSWORD = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    MA_NHAN_SU = table.Column<int>(type: "int", nullable: true),
                    NAME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PHONE = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    EMAIL = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    AVATAR = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ID_PHONG_BAN = table.Column<int>(type: "int", nullable: true),
                    NGAY_TAO = table.Column<DateTime>(type: "datetime", nullable: true),
                    NGUOI_TAO = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NGAY_CAP_NHAT = table.Column<DateTime>(type: "datetime", nullable: true),
                    NGUOI_CAP_NHAT = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SESSION_TOKEN = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    SALT = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: true),
                    IS_ADMIN = table.Column<bool>(type: "bit", nullable: true),
                    TRANG_THAI = table.Column<int>(type: "int", nullable: true),
                    IS_DELETE = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ADMIN_US__3214EC2739901ACE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BANNER",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IMAGE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    TITLE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SUB_TITLE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    URLS = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ORDERS = table.Column<int>(type: "int", nullable: false),
                    TYPE = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    UPDATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    ADMIN_CREATED = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ADMIN_UPDATED = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NOTES = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    STATUS = table.Column<byte>(type: "tinyint", nullable: false),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BANNER__3214EC274D7E8BD5", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CATEGORY",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TITLE = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ICON = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    MATE_TITLE = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    META_KEYWORD = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    META_DESCRIPTION = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    SLUG = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ORDERS = table.Column<int>(type: "int", nullable: true),
                    PARENTID = table.Column<int>(type: "int", nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    UPDATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    ADMIN_CREATED = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ADMIN_UPDATED = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NOTES = table.Column<string>(type: "ntext", nullable: true),
                    STATUS = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "((1))"),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PRODUCT___A88186B13985BFD1", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CONTACT",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TITLE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    EMAIL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PHONE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ADDRESS = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CONTENT = table.Column<string>(type: "ntext", nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    UPDATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    ADMIN_CREATED = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ADMIN_UPDATED = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    STATUS = table.Column<byte>(type: "tinyint", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CONTACT", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EXTENSION",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TITLE = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ICON = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    META_TITLE = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    META_KEYWORD = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    META_DESCRIPTION = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    SLUG = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ORDERS = table.Column<int>(type: "int", nullable: true),
                    PARENTID = table.Column<int>(type: "int", nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    UPDATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    ADMIN_CREATED = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ADMIN_UPDATED = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NOTES = table.Column<string>(type: "ntext", nullable: true),
                    STATUS = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "((1))"),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PRODUCT___EXTENSION", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "INFOR_COMPANY",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LOGO = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    PHONE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    EMAIL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ADDRESS = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    YOUTUBE = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    INSTAGRAM = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    FACEBOOK = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "date", nullable: true),
                    UPDATE_DATE = table.Column<DateTime>(type: "date", nullable: true),
                    ADMIN_CREATED = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ADMIN_UPDATED = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    META_TITLE = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    META_KEYWORD = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    META_DESCRIPTION = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INFOR_COMPANY", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "INTRODUCTIONS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TITLE = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    IMAGE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false, defaultValueSql: "('NO_IMAGE_AVAILABLE.jpg')"),
                    ORDERS = table.Column<int>(type: "int", nullable: true),
                    DESCRIPTION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HOME = table.Column<byte>(type: "tinyint", nullable: true),
                    TYPE = table.Column<byte>(type: "tinyint", nullable: true),
                    PARENTID = table.Column<int>(type: "int", nullable: true),
                    META_TITLE = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    META_KEYWORD = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    META_DESCRIPTION = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: true),
                    SLUG = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    UPDATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    ADMIN_CREATED = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ADMIN_UPDATED = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CONTENT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    STATUS = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "((1))"),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__INTRODUC__3214EC2715DFAD94", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MATERIAL",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TITLE = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ICON = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    META_TITLE = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    META_KEYWORD = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    META_DESCRIPTION = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    SLUG = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ORDERS = table.Column<int>(type: "int", nullable: true),
                    PARENTID = table.Column<int>(type: "int", nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    UPDATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true),
                    ADMIN_CREATED = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ADMIN_UPDATED = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NOTES = table.Column<string>(type: "ntext", nullable: true),
                    STATUS = table.Column<byte>(type: "tinyint", nullable: true),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__MATERIAL___EXTENSION", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "NEWS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    TITLE = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DESCRIPTION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CONTENT = table.Column<string>(type: "ntext", nullable: true),
                    IMAGE = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValueSql: "('NO_IMAGE_AVAILABLE.jpg')"),
                    META_TITLE = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    MAIN_KEYWORD = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    META_KEYWORD = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    META_DESCRIPTION = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    SLUG = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    VIEWS = table.Column<int>(type: "int", nullable: true),
                    LIKES = table.Column<int>(type: "int", nullable: true),
                    STAR = table.Column<double>(type: "float", nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    UPDATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    ADMIN_CREATED = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ADMIN_UPDATED = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    STATUS = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "((1))"),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__NEWS__3214EC27E639B94D", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PARTNER",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TITLE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LOGO = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "('NO_IMAGE_AVAILABLE.jpg')"),
                    URL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ORDERS = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "((1))"),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    UPDATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    ADMIN_CREATED = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ADMIN_UPDATED = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CONTENT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    STATUS = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "((1))"),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PARTNER__3214EC270260178F", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PRODUCT",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CID = table.Column<int>(type: "int", nullable: true),
                    CODE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    TITLE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DESCRIPTION = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CONTENT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IMAGE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "('NO_IMAGE_AVAILABLE.jpg')"),
                    META_TITLE = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    META_KEYWORD = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    META_DESCRIPTION = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    SLUG = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    PRICE_OLD = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    PRICE_NEW = table.Column<decimal>(type: "decimal(18,0)", nullable: true),
                    SIZE = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    VIEWS = table.Column<int>(type: "int", nullable: true),
                    LIKES = table.Column<int>(type: "int", nullable: true),
                    STAR = table.Column<double>(type: "float", nullable: true),
                    HOME = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "((0))"),
                    HOT = table.Column<byte>(type: "tinyint", nullable: true),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    UPDATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    ADMIN_CREATED = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ADMIN_UPDATED = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    STATUS = table.Column<byte>(type: "tinyint", nullable: true, defaultValueSql: "((1))"),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PRODUCT__3214EC27E639B94D", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PRODUCT_EXTENSIONS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PID = table.Column<int>(type: "int", nullable: true),
                    EID = table.Column<int>(type: "int", nullable: true),
                    CONTENT = table.Column<string>(type: "ntext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUCTEXTENSIONS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PRODUCT_IMAGES",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PID = table.Column<int>(type: "int", nullable: true),
                    IMAGE = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUCTIMAGES", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PRODUCT_MATERIALS",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PID = table.Column<int>(type: "int", nullable: true),
                    MID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUCTMATERIALS", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SLIDES",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IMAGE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true, defaultValueSql: "('NO_IMAGE_AVAILABLE.jpg')"),
                    TITLE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SUB_TITLE = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    URLS = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ORDERS = table.Column<int>(type: "int", nullable: false),
                    CREATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    UPDATED_DATE = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    ADMIN_CREATED = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ADMIN_UPDATED = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    NOTES = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    STATUS = table.Column<byte>(type: "tinyint", nullable: false, defaultValueSql: "((1))"),
                    ISDELETE = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SLIDES__3214EC279D085EE9", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ADMIN_LOG");

            migrationBuilder.DropTable(
                name: "ADMIN_USER");

            migrationBuilder.DropTable(
                name: "BANNER");

            migrationBuilder.DropTable(
                name: "CATEGORY");

            migrationBuilder.DropTable(
                name: "CONTACT");

            migrationBuilder.DropTable(
                name: "EXTENSION");

            migrationBuilder.DropTable(
                name: "INFOR_COMPANY");

            migrationBuilder.DropTable(
                name: "INTRODUCTIONS");

            migrationBuilder.DropTable(
                name: "MATERIAL");

            migrationBuilder.DropTable(
                name: "NEWS");

            migrationBuilder.DropTable(
                name: "PARTNER");

            migrationBuilder.DropTable(
                name: "PRODUCT");

            migrationBuilder.DropTable(
                name: "PRODUCT_EXTENSIONS");

            migrationBuilder.DropTable(
                name: "PRODUCT_IMAGES");

            migrationBuilder.DropTable(
                name: "PRODUCT_MATERIALS");

            migrationBuilder.DropTable(
                name: "SLIDES");
        }
    }
}
