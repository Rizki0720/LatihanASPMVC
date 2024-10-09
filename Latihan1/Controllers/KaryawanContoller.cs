using Latihan1.Data;
using Latihan1.Repositories;
using Latihan1.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace Latihan1.Controllers
{
    [Area("MasterData")]
    [Route("MasterData/[Controller]/[Action]")]
    public class KaryawanContoller : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IKaryawanRepository _karyawanRepository;
        private readonly IHostingEnvironment _hostingEnvironment;

        public KaryawanContoller(ApplicationDbContext context,IKaryawanRepository karyawan, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _karyawanRepository = karyawan;
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            try
            {
                var karyawan = HttpContext.Session.GetString("FullName");
                if(karyawan != null)
                {
                    ViewBag.Active = "Master Data";
                    var data = _karyawanRepository.GetAllKaryawan;
                    return View(data);
                };
                return View(karyawan);

            }catch(Exception ex)
            {
                throw new ArgumentOutOfRangeException("tidak bisa melakukan pengamblan data");
            }
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<ViewResult> CreateKaryawan()
        {
            ViewBag("MasterData");

            var karyawan = new KaryawanViewModel();
            var dateNow = DateTimeOffset.Now;
            var setDataNow = DateTimeOffset.Now.ToString("yyMMdd");

            //var lastCode = _karyawanRepository.GetAllKaryawan().OrderByDescending(p => p.FullName).FirstOrDefault();
            //if (lastCode == null)
            //{
            //    karyawan.EmployeeId;
            //}

            return View(karyawan);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> CreateKaryawan(KaryawanViewModel karyawan)
        {
            var dateNow = DateTimeOffset.Now;
            var setDataNow = DateTimeOffset.Now.ToString("yyMMdd");

            var getKaryawan =  _karyawanRepository.GetAllKaryawan().Where(u => u.FullName == User.Identity.Name).FirstOrDefault();

            if (ModelState.IsValid)
            {

            }
        }


        private string ProcessUpdloadFile(KaryawanContoller karyawan)
        {
            string fileName = null;
            if (model.Foto != null)
            {
                string uploadFolder = Path.Combine(_hostingEnvironment)
            }
        }
    }
}
