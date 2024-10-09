namespace Latihan1.ViewModels
{
    public class AbsensiKaryawanViewModel
    {
        public Guid AbsensiKaryawanId { get; set; }
        public string KodeKaryawan { get; set; }
        public string NamaKaryawan { get; set; }
        public DateTimeOffset TglMasuk { get; set; }
        public DateTimeOffset TglKeluar { get; set; }
        public DateTimeOffset JamMasuk { get; set; }
        public DateTimeOffset JamKeluar { get; set; }
    }
}
