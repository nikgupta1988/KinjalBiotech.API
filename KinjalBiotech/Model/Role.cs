using System.ComponentModel.DataAnnotations;

namespace KinjalBiotech.Model
{
    public class Role
    {
        [Key]
        public int RoleID { get; set; }
        public string RoleName { get; set; }
    }
}
