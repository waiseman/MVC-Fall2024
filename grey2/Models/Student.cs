using System.ComponentModel.DataAnnotations;

namespace grey2.Models
{
    public class Student
    {
        [Key]
        public int RollNo { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string ContactNo { get; set; }

    }
}
