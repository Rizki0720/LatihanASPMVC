using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Latihan1.Models
{
    [Table("MstAbsensiKaryawan", Schema = "dbo")]
    public class AbsensiKaryawan
    {
        [Key]
         public Guid AbsensiKaryawanId { get; set; }
         public string KodeKaryawan { get; set; }
         public string NamaKaryawan { get; set; }
         public DateTimeOffset TglMasuk { get; set; }
         public DateTimeOffset TglKeluar { get; set; }
         public DateTimeOffset JamMasuk { get; set; }
         public DateTimeOffset JamKeluar { get; set; }

    }
}
