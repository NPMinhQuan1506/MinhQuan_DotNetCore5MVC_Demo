using System.ComponentModel.DataAnnotations;

namespace MinhQuan_DotNetCoreMVC5_Demo.Models
{
    public class Contact
    {
        //[Required(ErrorMessage = "Không được để trống")]
        [Required]
        [Range(1, 10)]
        public int Id { get; set; }

        //[Required(ErrorMessage = "Không được để trống")]
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        //[Required(ErrorMessage = "Không được để trống")]
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        //[Required(ErrorMessage = "Không được để trống")]
        [Required]
        //[Phone(ErrorMessage = "Sai định dạng số điện thoại")]
        [Phone]
        public string Phone { get; set; }

        //[Required(ErrorMessage = "Không được để trống")]
        [Required]
        [StringLength(250)]
        public string Note { get; set; }
    }
}
