using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace MvcMovie.Models
{
    public class Blog
    {
        public int ID { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Snippet{ get; set; }
        public string Post{ get; set; }
        public string Category { get; set; }
        public int Published{ get; set; }

        public string Created { get; set; }

    }

    public class BlogDBContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
    }
}