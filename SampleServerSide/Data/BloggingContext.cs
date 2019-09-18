using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SampleServerSide
{
    public class BloggingContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        public BloggingContext(DbContextOptions<BloggingContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>().HasData(GenerateBlogs());
            modelBuilder.Entity<Post>().HasData(GeneratePosts());
        }

        private IEnumerable<Blog> GenerateBlogs()
        {
            var blogs = new List<Blog>();
            blogs.Add(
                new Blog
                {
                    BlogId = 1,
                    Rating = 5,
                    Url = "www.fakeblog.com"
                });
            blogs.Add(
                new Blog
                {
                    BlogId = 2,
                    Rating = 4,
                    Url = "www.fakeblog2.com"
                });
            blogs.Add(
                new Blog
                {
                    BlogId = 3,
                    Rating = 3,
                    Url = "www.fakeblog3.com"
                });
            return blogs;
        }

        private IEnumerable<Post> GeneratePosts()
        {
            var posts = new List<Post>();

            posts.Add(new Post
            {
                BlogId = 1,
                Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                PostId = 1,
                Title = "The Dummies Guide to Blazor",
                DatePosted = new DateTime(2019, 9, 1)
            });
            posts.Add(new Post
            {
                BlogId = 1,
                Content = "Donec non aliquet tortor, finibus gravida arcu. Donec ac eros eget tortor ultricies aliquam quis eget dolor. Proin vel enim sapien. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean a sapien nulla. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam ultrices erat at tempor vulputate. Mauris nec lacus sit amet augue egestas consequat eget in nunc.",
                PostId = 2,
                Title = "The 9 Best Blazor Twitter Feeds to Follow",
                DatePosted = new DateTime(2019, 8, 1)
            });
            posts.Add(new Post
            {
                BlogId = 1,
                Content = "Nunc suscipit dolor id ipsum scelerisque, ac dictum sem hendrerit. Aliquam ornare libero in est mollis pretium. Maecenas convallis diam sollicitudin tortor molestie consequat. Nullam massa nibh, sagittis nec dictum sed, viverra vitae lacus. Sed lorem ante, ultrices eu rhoncus eu, lobortis sed magna. Donec rutrum libero iaculis tellus convallis placerat. Donec non magna fermentum, dapibus libero ullamcorper, tempor urna. Suspendisse a nunc ac lectus faucibus porttitor. Suspendisse condimentum iaculis lacinia. Vivamus interdum dictum rhoncus. Cras lacinia quam non est dignissim consectetur. Praesent eu purus vel tortor aliquet dictum sed ut leo. Integer accumsan quam ipsum, in scelerisque elit ultrices a. Maecenas vel molestie risus.",
                PostId = 3,
                Title = "7 Facts About Blazor Everyone Thinks are True",
                DatePosted = new DateTime(2019, 7, 1)
            });
            posts.Add(new Post
            {
                BlogId = 1,
                Content = "Nam tincidunt dignissim elementum. Suspendisse condimentum nulla ut lectus pretium pharetra quis eget justo. In condimentum justo ac varius rutrum. Praesent et suscipit velit, non efficitur mauris. Donec cursus lorem eu dui sollicitudin, pharetra tristique massa accumsan. Curabitur et malesuada tellus. Fusce ac elementum elit, a condimentum eros.",
                PostId = 4,
                Title = "18 Podcasts About Blazor",
                DatePosted = new DateTime(2019, 6, 1)
            });
            posts.Add(new Post
            {
                BlogId = 1,
                Content = "Fusce consectetur cursus scelerisque. Mauris vestibulum aliquet gravida. Pellentesque vitae elit lectus. Suspendisse tempor aliquam risus, nec faucibus massa tincidunt ut. Vestibulum dapibus ligula sollicitudin odio interdum placerat. Curabitur tempus malesuada mi, a dignissim quam suscipit et. Nunc eget ultricies tellus, sit amet ultrices libero. Donec sollicitudin porta viverra. Mauris ac ligula sit amet dolor tincidunt hendrerit in vitae nibh. Mauris non mi purus. Fusce non convallis est. Fusce ipsum justo, malesuada mollis tortor a, scelerisque iaculis justo.",
                PostId = 5,
                Title = "Why Blazor Will Change Your Life",
                DatePosted = new DateTime(2019, 5, 1)
            });

            posts.Add(new Post
            {
                BlogId = 2,
                Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                PostId = 6,
                Title = "The Dummies Guide to ASP.NET",
                DatePosted = new DateTime(2019,9,1)
            });
            posts.Add(new Post
            {
                BlogId = 2,
                Content = "Donec non aliquet tortor, finibus gravida arcu. Donec ac eros eget tortor ultricies aliquam quis eget dolor. Proin vel enim sapien. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean a sapien nulla. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam ultrices erat at tempor vulputate. Mauris nec lacus sit amet augue egestas consequat eget in nunc.",
                PostId = 7,
                Title = "The 9 Best ASP.NET Twitter Feeds to Follow",
                DatePosted = new DateTime(2019, 8, 1)
            });
            posts.Add(new Post
            {
                BlogId = 2,
                Content = "Nunc suscipit dolor id ipsum scelerisque, ac dictum sem hendrerit. Aliquam ornare libero in est mollis pretium. Maecenas convallis diam sollicitudin tortor molestie consequat. Nullam massa nibh, sagittis nec dictum sed, viverra vitae lacus. Sed lorem ante, ultrices eu rhoncus eu, lobortis sed magna. Donec rutrum libero iaculis tellus convallis placerat. Donec non magna fermentum, dapibus libero ullamcorper, tempor urna. Suspendisse a nunc ac lectus faucibus porttitor. Suspendisse condimentum iaculis lacinia. Vivamus interdum dictum rhoncus. Cras lacinia quam non est dignissim consectetur. Praesent eu purus vel tortor aliquet dictum sed ut leo. Integer accumsan quam ipsum, in scelerisque elit ultrices a. Maecenas vel molestie risus.",
                PostId = 8,
                Title = "7 Facts About ASP.NET Everyone Thinks are True",
                DatePosted = new DateTime(2019, 7, 1)
            });
            posts.Add(new Post
            {
                BlogId = 2,
                Content = "Nam tincidunt dignissim elementum. Suspendisse condimentum nulla ut lectus pretium pharetra quis eget justo. In condimentum justo ac varius rutrum. Praesent et suscipit velit, non efficitur mauris. Donec cursus lorem eu dui sollicitudin, pharetra tristique massa accumsan. Curabitur et malesuada tellus. Fusce ac elementum elit, a condimentum eros.",
                PostId = 9,
                Title = "18 Podcasts About ASP.NET",
                DatePosted = new DateTime(2019, 6, 1)
            });
            posts.Add(new Post
            {
                BlogId = 2,
                Content = "Fusce consectetur cursus scelerisque. Mauris vestibulum aliquet gravida. Pellentesque vitae elit lectus. Suspendisse tempor aliquam risus, nec faucibus massa tincidunt ut. Vestibulum dapibus ligula sollicitudin odio interdum placerat. Curabitur tempus malesuada mi, a dignissim quam suscipit et. Nunc eget ultricies tellus, sit amet ultrices libero. Donec sollicitudin porta viverra. Mauris ac ligula sit amet dolor tincidunt hendrerit in vitae nibh. Mauris non mi purus. Fusce non convallis est. Fusce ipsum justo, malesuada mollis tortor a, scelerisque iaculis justo.",
                PostId = 10,
                Title = "Why ASP.NET Will Change Your Life",
                DatePosted = new DateTime(2019, 5, 1)
            });
            posts.Add(new Post
            {
                BlogId = 3,
                Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                PostId = 11,
                Title = "The Dummies Guide to Telerik UI",
                DatePosted = new DateTime(2019, 9, 1)
            });
            posts.Add(new Post
            {
                BlogId = 3,
                Content = "Donec non aliquet tortor, finibus gravida arcu. Donec ac eros eget tortor ultricies aliquam quis eget dolor. Proin vel enim sapien. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Aenean a sapien nulla. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam ultrices erat at tempor vulputate. Mauris nec lacus sit amet augue egestas consequat eget in nunc.",
                PostId = 12,
                Title = "The 9 Best Telerik UI Twitter Feeds to Follow",
                DatePosted = new DateTime(2019, 8, 1)
            });
            posts.Add(new Post
            {
                BlogId = 3,
                Content = "Nunc suscipit dolor id ipsum scelerisque, ac dictum sem hendrerit. Aliquam ornare libero in est mollis pretium. Maecenas convallis diam sollicitudin tortor molestie consequat. Nullam massa nibh, sagittis nec dictum sed, viverra vitae lacus. Sed lorem ante, ultrices eu rhoncus eu, lobortis sed magna. Donec rutrum libero iaculis tellus convallis placerat. Donec non magna fermentum, dapibus libero ullamcorper, tempor urna. Suspendisse a nunc ac lectus faucibus porttitor. Suspendisse condimentum iaculis lacinia. Vivamus interdum dictum rhoncus. Cras lacinia quam non est dignissim consectetur. Praesent eu purus vel tortor aliquet dictum sed ut leo. Integer accumsan quam ipsum, in scelerisque elit ultrices a. Maecenas vel molestie risus.",
                PostId = 13,
                Title = "7 Facts About Telerik UI Everyone Thinks are True",
                DatePosted = new DateTime(2019, 7, 1)

            });
            posts.Add(new Post
            {
                BlogId = 3,
                Content = "Nam tincidunt dignissim elementum. Suspendisse condimentum nulla ut lectus pretium pharetra quis eget justo. In condimentum justo ac varius rutrum. Praesent et suscipit velit, non efficitur mauris. Donec cursus lorem eu dui sollicitudin, pharetra tristique massa accumsan. Curabitur et malesuada tellus. Fusce ac elementum elit, a condimentum eros.",
                PostId = 14,
                Title = "18 Podcasts About Telerik UI",
                DatePosted = new DateTime(2019, 6, 1)

            });
            posts.Add(new Post
            {
                BlogId = 3,
                Content = "Fusce consectetur cursus scelerisque. Mauris vestibulum aliquet gravida. Pellentesque vitae elit lectus. Suspendisse tempor aliquam risus, nec faucibus massa tincidunt ut. Vestibulum dapibus ligula sollicitudin odio interdum placerat. Curabitur tempus malesuada mi, a dignissim quam suscipit et. Nunc eget ultricies tellus, sit amet ultrices libero. Donec sollicitudin porta viverra. Mauris ac ligula sit amet dolor tincidunt hendrerit in vitae nibh. Mauris non mi purus. Fusce non convallis est. Fusce ipsum justo, malesuada mollis tortor a, scelerisque iaculis justo.",
                PostId = 15,
                Title = "Why Telerik UI Will Change Your Life",
                DatePosted = new DateTime(2019, 5, 1)
            });

            return posts;
        }
    }




}
