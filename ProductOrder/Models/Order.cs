using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductOrder.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [Column(TypeName = "nvarchar(12)")]
        [DisplayName("Order Number")]
        [Required(ErrorMessage = "This field is required.")]
        [MaxLength(12, ErrorMessage = "Maximum 12 characters only.")]
        public string OrderNumber { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Order Name")]
        [Required(ErrorMessage = "This field is required.")]
        public string OrderName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Phone No")]
        [Required(ErrorMessage = "This field is required.")]
        public string PhoneNo { get; set; }

        [Column(TypeName = "nvarchar(11)")]
        [Required(ErrorMessage = "This field is required.")]
        [MaxLength(11, ErrorMessage = "Maximum 11 characters only.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public int Amount { get; set; }

        [DisplayFormat(DataFormatString = "{0:MMM-dd-yy}")]
        public DateTime Date { get; set; }
    }
}
