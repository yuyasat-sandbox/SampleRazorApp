using System;
using System.ComponentModel.DataAnnotations;

namespace SampleRazorApp.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        [Display(Name = "名前")]
        [Required(ErrorMessage = "必須項目です。")]
        public string Name { get; set; }
        [Display(Name = "メールアドレス")]
        [EmailAddress(ErrorMessage = "メールアドレスが必要です")]
        public string? Mail { get; set; }
        [Display(Name = "年齢")]
        [Range(0, 200, ErrorMessage = "0以上、200以下の値にしてください。")]
        public int Age { get; set; }

        [Display(Name = "投稿")]
        public ICollection<Message> Messages { get; set; }
    }
}