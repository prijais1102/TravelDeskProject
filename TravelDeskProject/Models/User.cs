using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelDeskProject.Models
{
    public class User
    {
        [Required]
        public int UserId { get; set; }
        [Required]
        [RegularExpression("[a-zA-Z]+", ErrorMessage = "Only alphabets allowed")]
        [MaxLength(15)]
        public string FirstName { get; set; }
        [Required]
        [RegularExpression("[a-zA-Z]+", ErrorMessage = "Only alphabets allowed")]
        [MaxLength(15)]
        public string LastName { get; set; }
        [Required]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")]

        public string Email { get; set; }
        [Required]
        [MinLength(8)]
        public string Password { get; set; }
        [Required]
        [MaxLength(50)]
        public string Address { get; set; }
        [Required]
        [RegularExpression("[0-9]{10}", ErrorMessage = "Only digits allowed")]
        public string MobileNumber { get; set; }
        [Required]
        public int CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
        [Required]
        public DateTime CreatedOn { get; set; }= DateTime.Now;
        public DateTime? UpdatedOn { get; set;}
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public int RoleId { get; set; }
        public Role? Role { get; set; }
        [Required]
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }
        public int? ManagerId { get; set; }
        [ForeignKey("ManagerId")]
        public User? user { get; set; }

    }
}
