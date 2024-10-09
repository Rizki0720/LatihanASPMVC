using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Latihan1.Models
{
    [Table("MstKaryawan", Schema = "dbo")]
    public class Karyawan
    {
        [Key]
        public Guid EmployeeId { get; set; }
        public string FullName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string Gender { get; set; }
        public string address { get; set; }
        public string hp { get; set; }
        public string? foto { get; set; }
        public string isActive {  get; set; } 


    }
}
