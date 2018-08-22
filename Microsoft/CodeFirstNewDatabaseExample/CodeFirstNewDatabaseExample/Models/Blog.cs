using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstNewDatabaseExample.Models
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        public string Name { get; set; }

        public string Url { get; set; }

        public virtual List<Post> Posts { get; set; }
    }
}
