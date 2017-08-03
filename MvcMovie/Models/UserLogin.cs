using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace MvcMovie.Models
{
    public class UserLogin
    {
        [Key]
        public int UserID { get; set; }

        public string FirstName { get; set; }

        public string LastName{ get; set; }

        public string Email { get; set; }

        public string UserName{ get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }
    }

    public class UserLoginDBContext : DbContext
    {
        public DbSet<UserLogin> UserLogin { get; set; }
    }
}