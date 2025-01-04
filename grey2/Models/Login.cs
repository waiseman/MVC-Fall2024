using System.ComponentModel.DataAnnotations;

namespace grey2.Models
{
    public class Login
    {
        [Key]
        public string uname { get; set; }
        public string upass { get; set; }
    }
}
