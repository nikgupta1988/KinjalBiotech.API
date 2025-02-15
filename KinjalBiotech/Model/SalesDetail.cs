using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace KinjalBiotech.Model
{
    public class SalesDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SellID { get; set; }

        //[ForeignKey("ProductDetail")]
        //public int ProductID { get; set; }

        [ForeignKey("CategoryDetail")]
        public int CategoryID { get; set; }

        [ForeignKey("UserDetail")]
        public int UserID { get; set; }
        public int Quantity { get; set; }
        public DateTime SellDate { get; set; }
        public int CustID { get; set; }
        public decimal SellPrise { get; set; }

        // Navigation property
      
        
        //public ProductDetail ProductDetail { get; set; }
        public CategoryDetail CategoryDetail { get; set; }
        public UserDetail UserDetail { get; set; }
    }
}
