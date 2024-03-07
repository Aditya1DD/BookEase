using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace StudentData1.Models
{
    public class StudentViewModel
    {
        public int Id { get; set; }

        [DisplayName("FirstName")]
        public string FirstName { get; set; }
        [DisplayName("LastName")]
        public string LastName { get; set; }
        [DisplayName("DateOfBirth")]
        public DateTime DateOfBirth { get; set; }
        [DisplayName("Email")]
        public string Email { get; set; }
        //[DisplayName("MobNo")]
        public string MobNO { get; set; }

        [DisplayName("Name")]
        public string FullName
        {
            get {return FirstName+ " "  +LastName;}
        }
    }
}
