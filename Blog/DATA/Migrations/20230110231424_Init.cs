﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.DATA.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Despatches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ChangedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Despatches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Despatches_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Genel" },
                    { 2, "Gezilerim" },
                    { 3, "Mutfağım" },
                    { 4, "İş Dünyası" }
                });

            migrationBuilder.InsertData(
                table: "Despatches",
                columns: new[] { "Id", "CategoryId", "ChangedDate", "Content", "CreatedDate", "Image", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7342), "\r\n<p>Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.</p>\r\n<p>Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante.</p>", new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7329), null, "Text Example 0" },
                    { 2, 1, new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7407), "\r\n<p>Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.</p>\r\n<p>Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante.</p>", new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7406), null, "Text Example 1" },
                    { 3, 1, new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7415), "\r\n<p>Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.</p>\r\n<p>Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante.</p>", new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7414), null, "Text Example 2" },
                    { 4, 1, new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7421), "\r\n<p>Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.</p>\r\n<p>Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante.</p>", new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7420), null, "Text Example 3" },
                    { 5, 1, new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7427), "\r\n<p>Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.</p>\r\n<p>Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante.</p>", new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7426), null, "Text Example 4" },
                    { 6, 1, new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7433), "\r\n<p>Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.</p>\r\n<p>Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante.</p>", new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7432), null, "Text Example 5" },
                    { 7, 1, new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7439), "\r\n<p>Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.</p>\r\n<p>Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante.</p>", new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7438), null, "Text Example 6" },
                    { 8, 1, new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7445), "\r\n<p>Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.</p>\r\n<p>Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante.</p>", new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7444), null, "Text Example 7" },
                    { 9, 1, new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7452), "\r\n<p>Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.</p>\r\n<p>Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante.</p>", new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7451), null, "Text Example 8" },
                    { 10, 1, new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7457), "\r\n<p>Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.</p>\r\n<p>Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante.</p>", new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7456), null, "Text Example 9" },
                    { 11, 1, new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7463), "\r\n<p>Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.</p>\r\n<p>Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante.</p>", new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7462), null, "Text Example 10" },
                    { 12, 1, new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7470), "\r\n<p>Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.</p>\r\n<p>Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante.</p>", new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7469), null, "Text Example 11" },
                    { 13, 2, new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7476), "\r\n<p>Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.</p>\r\n<p>Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante.</p>", new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7475), null, "Text Example 12" },
                    { 14, 2, new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7483), "\r\n<p>Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.</p>\r\n<p>Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante.</p>", new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7482), null, "Text Example 13" },
                    { 15, 2, new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7489), "\r\n<p>Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.</p>\r\n<p>Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante.</p>", new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7488), null, "Text Example 14" },
                    { 16, 2, new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7496), "\r\n<p>Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.</p>\r\n<p>Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante.</p>", new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7495), null, "Text Example 15" },
                    { 17, 2, new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7525), "\r\n<p>Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.</p>\r\n<p>Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante.</p>", new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7524), null, "Text Example 16" },
                    { 18, 2, new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7532), "\r\n<p>Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.</p>\r\n<p>Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante.</p>", new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7531), null, "Text Example 17" },
                    { 19, 2, new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7538), "\r\n<p>Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.</p>\r\n<p>Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante.</p>", new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7537), null, "Text Example 18" },
                    { 20, 2, new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7545), "\r\n<p>Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.</p>\r\n<p>Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante.</p>", new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7543), null, "Text Example 19" },
                    { 21, 2, new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7550), "\r\n<p>Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.</p>\r\n<p>Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante.</p>", new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7549), null, "Text Example 20" },
                    { 22, 2, new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7556), "\r\n<p>Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.</p>\r\n<p>Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante.</p>", new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7555), null, "Text Example 21" },
                    { 23, 2, new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7564), "\r\n<p>Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.</p>\r\n<p>Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante.</p>", new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7563), null, "Text Example 22" },
                    { 24, 2, new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7569), "\r\n<p>Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.</p>\r\n<p>Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante.</p>", new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7569), null, "Text Example 23" },
                    { 25, 3, new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7575), "\r\n<p>Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.</p>\r\n<p>Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante.</p>", new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7574), null, "Text Example 24" },
                    { 26, 3, new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7582), "\r\n<p>Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.</p>\r\n<p>Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante.</p>", new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7580), null, "Text Example 25" },
                    { 27, 3, new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7588), "\r\n<p>Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.</p>\r\n<p>Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante.</p>", new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7587), null, "Text Example 26" },
                    { 28, 3, new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7593), "\r\n<p>Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.</p>\r\n<p>Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante.</p>", new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7592), null, "Text Example 27" },
                    { 29, 3, new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7599), "\r\n<p>Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.</p>\r\n<p>Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante.</p>", new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7598), null, "Text Example 28" },
                    { 30, 3, new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7605), "\r\n<p>Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.</p>\r\n<p>Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante.</p>", new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7604), null, "Text Example 29" },
                    { 31, 3, new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7611), "\r\n<p>Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.</p>\r\n<p>Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante.</p>", new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7610), null, "Text Example 30" },
                    { 32, 3, new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7617), "\r\n<p>Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.</p>\r\n<p>Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante.</p>", new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7616), null, "Text Example 31" },
                    { 33, 3, new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7623), "\r\n<p>Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.</p>\r\n<p>Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante.</p>", new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7622), null, "Text Example 32" },
                    { 34, 3, new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7629), "\r\n<p>Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.</p>\r\n<p>Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante.</p>", new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7628), null, "Text Example 33" },
                    { 35, 3, new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7634), "\r\n<p>Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.</p>\r\n<p>Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante.</p>", new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7633), null, "Text Example 34" },
                    { 36, 3, new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7639), "\r\n<p>Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.</p>\r\n<p>Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante.</p>", new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7639), null, "Text Example 35" },
                    { 37, 4, new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7645), "\r\n<p>Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.</p>\r\n<p>Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante.</p>", new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7644), null, "Text Example 36" },
                    { 38, 4, new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7650), "\r\n<p>Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.</p>\r\n<p>Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante.</p>", new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7649), null, "Text Example 37" },
                    { 39, 4, new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7656), "\r\n<p>Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.</p>\r\n<p>Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante.</p>", new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7655), null, "Text Example 38" },
                    { 40, 4, new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7661), "\r\n<p>Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.</p>\r\n<p>Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante.</p>", new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7660), null, "Text Example 39" },
                    { 41, 4, new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7667), "\r\n<p>Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.</p>\r\n<p>Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante.</p>", new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7666), null, "Text Example 40" },
                    { 42, 4, new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7673), "\r\n<p>Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.</p>\r\n<p>Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante.</p>", new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7672), null, "Text Example 41" }
                });

            migrationBuilder.InsertData(
                table: "Despatches",
                columns: new[] { "Id", "CategoryId", "ChangedDate", "Content", "CreatedDate", "Image", "Title" },
                values: new object[,]
                {
                    { 43, 4, new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7679), "\r\n<p>Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.</p>\r\n<p>Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante.</p>", new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7678), null, "Text Example 42" },
                    { 44, 4, new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7686), "\r\n<p>Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.</p>\r\n<p>Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante.</p>", new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7686), null, "Text Example 43" },
                    { 45, 4, new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7692), "\r\n<p>Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.</p>\r\n<p>Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante.</p>", new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7691), null, "Text Example 44" },
                    { 46, 4, new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7697), "\r\n<p>Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.</p>\r\n<p>Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante.</p>", new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7696), null, "Text Example 45" },
                    { 47, 4, new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7703), "\r\n<p>Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.</p>\r\n<p>Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante.</p>", new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7702), null, "Text Example 46" },
                    { 48, 4, new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7709), "\r\n<p>Tincidunt integer eu augue augue nunc elit dolor, luctus placerat scelerisque euismod, iaculis eu lacus nunc mi elit, vehicula ut laoreet ac, aliquam sit amet justo nunc tempor, metus vel.</p>\r\n<p>Placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor mattis ut vitae feugiat augue cras ut metus a risus iaculis scelerisque eu ac ante.</p>", new DateTime(2023, 1, 11, 2, 14, 23, 583, DateTimeKind.Local).AddTicks(7708), null, "Text Example 47" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Despatches_CategoryId",
                table: "Despatches",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Despatches");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
