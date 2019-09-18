using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SampleServerSide
{
    public class Post
    {
        public int PostId { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Title may not exceed 50 characters.")]
        public string Title { get; set; }
        [Required]
        [MinLength(100, ErrorMessage = "Content must be 100 words or more.")]
        public string Content { get; set; }
        [Required]
        public int BlogId { get; set; }
        public DateTime DatePosted { get; set; } = DateTime.Now;
        public Blog Blog { get; set; }

        // Blazor can only bind select input to a string value
        [Required(AllowEmptyStrings = false)]
        [NotMapped] // Form Field Only
        public string SelectedBlogId
        {
            get => BlogId == 0 ? string.Empty : BlogId.ToString();
            set => BlogId = int.Parse(value);
        }

        [NotMapped] // Form Field Only
        public Blog[] BlogList { get; set; }
    }
}
