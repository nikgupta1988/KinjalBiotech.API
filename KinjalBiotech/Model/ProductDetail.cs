using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KinjalBiotech.Model
{
    public class ProductDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int ProductID { get; set; }

        [ForeignKey("CategoryDetail")]
        public int CategoryID { get; set; }

        [Required]
        public string ProductName { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal Price { get; set; }
        public string imegeUrl { get; set; }
        public decimal Discount { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        // Navigation Property (Many Products belong to One Category)
        //Nabigation props 
        public CategoryDetail CategoryDetail { get; set; }
    }
}
