using System.ComponentModel.DataAnnotations;

namespace SampleRazorApp.Models
{
    public class Message
    {
        public int MessageId { get; set; }
        [Display(Name = "メッセージ")]
        [Required]
        public string Comment { get; set; }
        [Display(Name = "投稿者")]
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}

