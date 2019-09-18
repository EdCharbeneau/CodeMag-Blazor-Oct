using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SampleServerSide.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    BlogId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Url = table.Column<string>(nullable: true),
                    Rating = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.BlogId);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    PostId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(maxLength: 25, nullable: false),
                    Content = table.Column<string>(nullable: false),
                    BlogId = table.Column<int>(nullable: false),
                    DatePosted = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.PostId);
                    table.ForeignKey(
                        name: "FK_Posts_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs",
                        principalColumn: "BlogId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "BlogId", "Rating", "Url" },
                values: new object[] { 1, 5, "www.fakeblog.com" });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "BlogId", "Rating", "Url" },
                values: new object[] { 2, 4, "www.fakeblog2.com" });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "BlogId", "Rating", "Url" },
                values: new object[] { 3, 3, "www.fakeblog3.com" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "BlogId", "Content", "DatePosted", "Title" },
                values: new object[] { 1, 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", new DateTime(2019, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dummies Guide to Blazor" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "BlogId", "Content", "DatePosted", "Title" },
                values: new object[] { 2, 1, "Donec non aliquet tortor, finibus gravida arcu. Donec ac eros eget tortor ultricies aliquam quis eget dolor. Proin vel enim sapien. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean a sapien nulla. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam ultrices erat at tempor vulputate. Mauris nec lacus sit amet augue egestas consequat eget in nunc.", new DateTime(2019, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The 9 Best Blazor Twitter Feeds to Follow" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "BlogId", "Content", "DatePosted", "Title" },
                values: new object[] { 3, 1, "Nunc suscipit dolor id ipsum scelerisque, ac dictum sem hendrerit. Aliquam ornare libero in est mollis pretium. Maecenas convallis diam sollicitudin tortor molestie consequat. Nullam massa nibh, sagittis nec dictum sed, viverra vitae lacus. Sed lorem ante, ultrices eu rhoncus eu, lobortis sed magna. Donec rutrum libero iaculis tellus convallis placerat. Donec non magna fermentum, dapibus libero ullamcorper, tempor urna. Suspendisse a nunc ac lectus faucibus porttitor. Suspendisse condimentum iaculis lacinia. Vivamus interdum dictum rhoncus. Cras lacinia quam non est dignissim consectetur. Praesent eu purus vel tortor aliquet dictum sed ut leo. Integer accumsan quam ipsum, in scelerisque elit ultrices a. Maecenas vel molestie risus.", new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7 Facts About Blazor Everyone Thinks are True" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "BlogId", "Content", "DatePosted", "Title" },
                values: new object[] { 4, 1, "Nam tincidunt dignissim elementum. Suspendisse condimentum nulla ut lectus pretium pharetra quis eget justo. In condimentum justo ac varius rutrum. Praesent et suscipit velit, non efficitur mauris. Donec cursus lorem eu dui sollicitudin, pharetra tristique massa accumsan. Curabitur et malesuada tellus. Fusce ac elementum elit, a condimentum eros.", new DateTime(2019, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "18 Podcasts About Blazor" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "BlogId", "Content", "DatePosted", "Title" },
                values: new object[] { 5, 1, "Fusce consectetur cursus scelerisque. Mauris vestibulum aliquet gravida. Pellentesque vitae elit lectus. Suspendisse tempor aliquam risus, nec faucibus massa tincidunt ut. Vestibulum dapibus ligula sollicitudin odio interdum placerat. Curabitur tempus malesuada mi, a dignissim quam suscipit et. Nunc eget ultricies tellus, sit amet ultrices libero. Donec sollicitudin porta viverra. Mauris ac ligula sit amet dolor tincidunt hendrerit in vitae nibh. Mauris non mi purus. Fusce non convallis est. Fusce ipsum justo, malesuada mollis tortor a, scelerisque iaculis justo.", new DateTime(2019, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Why Blazor Will Change Your Life" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "BlogId", "Content", "DatePosted", "Title" },
                values: new object[] { 6, 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", new DateTime(2019, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dummies Guide to ASP.NET" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "BlogId", "Content", "DatePosted", "Title" },
                values: new object[] { 7, 2, "Donec non aliquet tortor, finibus gravida arcu. Donec ac eros eget tortor ultricies aliquam quis eget dolor. Proin vel enim sapien. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean a sapien nulla. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam ultrices erat at tempor vulputate. Mauris nec lacus sit amet augue egestas consequat eget in nunc.", new DateTime(2019, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The 9 Best ASP.NET Twitter Feeds to Follow" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "BlogId", "Content", "DatePosted", "Title" },
                values: new object[] { 8, 2, "Nunc suscipit dolor id ipsum scelerisque, ac dictum sem hendrerit. Aliquam ornare libero in est mollis pretium. Maecenas convallis diam sollicitudin tortor molestie consequat. Nullam massa nibh, sagittis nec dictum sed, viverra vitae lacus. Sed lorem ante, ultrices eu rhoncus eu, lobortis sed magna. Donec rutrum libero iaculis tellus convallis placerat. Donec non magna fermentum, dapibus libero ullamcorper, tempor urna. Suspendisse a nunc ac lectus faucibus porttitor. Suspendisse condimentum iaculis lacinia. Vivamus interdum dictum rhoncus. Cras lacinia quam non est dignissim consectetur. Praesent eu purus vel tortor aliquet dictum sed ut leo. Integer accumsan quam ipsum, in scelerisque elit ultrices a. Maecenas vel molestie risus.", new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7 Facts About ASP.NET Everyone Thinks are True" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "BlogId", "Content", "DatePosted", "Title" },
                values: new object[] { 9, 2, "Nam tincidunt dignissim elementum. Suspendisse condimentum nulla ut lectus pretium pharetra quis eget justo. In condimentum justo ac varius rutrum. Praesent et suscipit velit, non efficitur mauris. Donec cursus lorem eu dui sollicitudin, pharetra tristique massa accumsan. Curabitur et malesuada tellus. Fusce ac elementum elit, a condimentum eros.", new DateTime(2019, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "18 Podcasts About ASP.NET" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "BlogId", "Content", "DatePosted", "Title" },
                values: new object[] { 10, 2, "Fusce consectetur cursus scelerisque. Mauris vestibulum aliquet gravida. Pellentesque vitae elit lectus. Suspendisse tempor aliquam risus, nec faucibus massa tincidunt ut. Vestibulum dapibus ligula sollicitudin odio interdum placerat. Curabitur tempus malesuada mi, a dignissim quam suscipit et. Nunc eget ultricies tellus, sit amet ultrices libero. Donec sollicitudin porta viverra. Mauris ac ligula sit amet dolor tincidunt hendrerit in vitae nibh. Mauris non mi purus. Fusce non convallis est. Fusce ipsum justo, malesuada mollis tortor a, scelerisque iaculis justo.", new DateTime(2019, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Why ASP.NET Will Change Your Life" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "BlogId", "Content", "DatePosted", "Title" },
                values: new object[] { 11, 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", new DateTime(2019, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dummies Guide to Telerik UI" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "BlogId", "Content", "DatePosted", "Title" },
                values: new object[] { 12, 3, "Donec non aliquet tortor, finibus gravida arcu. Donec ac eros eget tortor ultricies aliquam quis eget dolor. Proin vel enim sapien. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean a sapien nulla. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam ultrices erat at tempor vulputate. Mauris nec lacus sit amet augue egestas consequat eget in nunc.", new DateTime(2019, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The 9 Best Telerik UI Twitter Feeds to Follow" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "BlogId", "Content", "DatePosted", "Title" },
                values: new object[] { 13, 3, "Nunc suscipit dolor id ipsum scelerisque, ac dictum sem hendrerit. Aliquam ornare libero in est mollis pretium. Maecenas convallis diam sollicitudin tortor molestie consequat. Nullam massa nibh, sagittis nec dictum sed, viverra vitae lacus. Sed lorem ante, ultrices eu rhoncus eu, lobortis sed magna. Donec rutrum libero iaculis tellus convallis placerat. Donec non magna fermentum, dapibus libero ullamcorper, tempor urna. Suspendisse a nunc ac lectus faucibus porttitor. Suspendisse condimentum iaculis lacinia. Vivamus interdum dictum rhoncus. Cras lacinia quam non est dignissim consectetur. Praesent eu purus vel tortor aliquet dictum sed ut leo. Integer accumsan quam ipsum, in scelerisque elit ultrices a. Maecenas vel molestie risus.", new DateTime(2019, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "7 Facts About Telerik UI Everyone Thinks are True" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "BlogId", "Content", "DatePosted", "Title" },
                values: new object[] { 14, 3, "Nam tincidunt dignissim elementum. Suspendisse condimentum nulla ut lectus pretium pharetra quis eget justo. In condimentum justo ac varius rutrum. Praesent et suscipit velit, non efficitur mauris. Donec cursus lorem eu dui sollicitudin, pharetra tristique massa accumsan. Curabitur et malesuada tellus. Fusce ac elementum elit, a condimentum eros.", new DateTime(2019, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "18 Podcasts About Telerik UI" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "PostId", "BlogId", "Content", "DatePosted", "Title" },
                values: new object[] { 15, 3, "Fusce consectetur cursus scelerisque. Mauris vestibulum aliquet gravida. Pellentesque vitae elit lectus. Suspendisse tempor aliquam risus, nec faucibus massa tincidunt ut. Vestibulum dapibus ligula sollicitudin odio interdum placerat. Curabitur tempus malesuada mi, a dignissim quam suscipit et. Nunc eget ultricies tellus, sit amet ultrices libero. Donec sollicitudin porta viverra. Mauris ac ligula sit amet dolor tincidunt hendrerit in vitae nibh. Mauris non mi purus. Fusce non convallis est. Fusce ipsum justo, malesuada mollis tortor a, scelerisque iaculis justo.", new DateTime(2019, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Why Telerik UI Will Change Your Life" });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_BlogId",
                table: "Posts",
                column: "BlogId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Blogs");
        }
    }
}
