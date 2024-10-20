using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Post
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Title { get; set; }

    [Required]
    public string Content { get; set; }

    // Foreign Key linking to User
    public int UserId { get; set; }

    [ForeignKey("UserId")]
    public User User { get; set; }  // Navigation property
}
