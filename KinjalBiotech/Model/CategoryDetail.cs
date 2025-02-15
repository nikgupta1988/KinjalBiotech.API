using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace KinjalBiotech.Model
{
    public class CategoryDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoruID { get; set; }
        public string CategoryName { get; set; }
    }
}
