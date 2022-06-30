using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApp.API.Models
{
    public class UserTokenModel
    {
        [Required]
        public string username { get; set; }
        [Required]
        public string userId { get; set; }

    }
}
