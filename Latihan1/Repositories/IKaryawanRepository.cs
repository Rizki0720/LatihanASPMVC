using Latihan1.Data;
using Latihan1.Models;
using Microsoft.EntityFrameworkCore;

namespace Latihan1.Repositories
{
    public class IKaryawanRepository
    {
        private readonly ApplicationDbContext _context;

        public IKaryawanRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Karyawan Tambah(Karyawan karyawan)
        {
            _context.Karyawans.Add(karyawan);
            _context.SaveChanges();
            return karyawan;
        }

        public async Task<Karyawan> GetKaryawanId(Guid Id)
        {
            var Karyawan = await _context.Karyawans.SingleOrDefaultAsync(i => i.EmployeeId == Id);

            if(Karyawan != null)
            {
                var KaryawanDetail = new Karyawan()
                {
                    EmployeeId = Id,
                    FullName = Karyawan.FullName,
                    email = Karyawan.email,
                    password = Karyawan.password,
                    Gender = Karyawan.Gender,
                    address = Karyawan.address,
                    hp = Karyawan.hp
                };
                return KaryawanDetail;
            }
            return null;
        }

        public async Task<Karyawan> GetKaryawanNoTracking(Guid Id)
        {
            return await _context.Karyawans.AsNoTracking().FirstOrDefaultAsync(i => i.EmployeeId == Id);
        }


        public async Task<List<Karyawan>> GetKaryawan()
        {
            return await _context.Karyawans.Where(u => u.FullName != "Administrator").Select(Karyawan => new Karyawan()
            {
                  EmployeeId = Karyawan.EmployeeId,
                  FullName = Karyawan.FullName,
                  email = Karyawan.email,
                  password = Karyawan.password,
                  Gender = Karyawan.Gender,
                  address = Karyawan.address,
                  hp = Karyawan.hp
            }).ToListAsync();
        }

        public IEnumerable<Karyawan> GetAllKaryawan()
        {
            return _context.Karyawans.AsNoTracking();
        }

        public Karyawan Update(Karyawan update)
        {
            var karyawan = _context.Karyawans.Attach(update);
            karyawan.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return update;
        }

        public Karyawan Delete(Guid Id)
        {
            var karyawan = _context.Karyawans.Find(Id);
            if(karyawan != null)
            {
                _context.Karyawans.Remove(karyawan);
                _context.SaveChanges();
            }
            return karyawan;
        }
















    }
}
