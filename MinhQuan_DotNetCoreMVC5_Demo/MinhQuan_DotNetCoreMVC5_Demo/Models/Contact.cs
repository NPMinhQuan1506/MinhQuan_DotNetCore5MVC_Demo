using System.ComponentModel.DataAnnotations;

namespace MinhQuan_DotNetCoreMVC5_Demo.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "Không được để trống")]
        [Range(1, 10)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Không được để trống")]
        [StringLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Không được để trống")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Không được để trống")]
        [Phone(ErrorMessage = "Sai định dạng số điện thoại")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Không được để trống")]
        [StringLength(100)]
        public string Address { get; set; }
    }
}
