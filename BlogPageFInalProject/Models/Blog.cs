using System;
using System.ComponentModel.DataAnnotations;

namespace BlogPageFInalProject.Models
{
    public class Blog
    {
         
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public DateTime Date { get; set; } = DateTime.Now;


    }
}
