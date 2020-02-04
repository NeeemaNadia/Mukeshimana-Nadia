using System.ComponentModel.DataAnnotations;

namespace Nadia218005170.Models
{
    public class Books
    {
        [Key]
        public int id { get; set; }

        public string ISBN{ get; set; }
        public string BookTitle { get; set; }
        
    }
}