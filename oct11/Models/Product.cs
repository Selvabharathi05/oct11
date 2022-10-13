using System.ComponentModel.DataAnnotations;

namespace oct11.Models
{
    public class Product
    {

        [Required()]
        public int Prodid { get; set; }
        [MaxLength(10, ErrorMessage = "Product Name cannot be greater than 10 characters")]
        [MinLength(3, ErrorMessage = "Product Name cannot be less than 3 character")]
        public string Prodname { get; set; }
        public int Count { get; set; }



        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime MfgDate { get; set; }
    }
}
