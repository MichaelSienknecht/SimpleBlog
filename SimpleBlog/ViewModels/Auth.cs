using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SimpleBlog.ViewModels
{
    public class AuthLogin
    {
        [Required]
        public string username { get; set; }

        [Required,DataType(DataType.Password)]
        public string password { get; set; }
    }
}