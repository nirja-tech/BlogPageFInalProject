using System;
using System.ComponentModel.DataAnnotations;

namespace BlogPageClassLibrary
{
    public class Class1
    {

        [Required(ErrorMessage = "Please provide a title")]
        public string EmailID
        {
            get; set;
        }
    }
}
