using DOANDATVEMAYBAY2023.Models;

namespace DOANDATVEMAYBAY2023.Services
{
    public class SanBayServiceImpl : SanBayService
    {
        private DatabaseContext db;
        private IConfiguration configuration;
        public SanBayServiceImpl(DatabaseContext _db, IConfiguration _configuration)
        {
            this.db = _db;
            this.configuration = _configuration;
        }

        public dynamic find(string maSbaydi, string maSbayden)
        {
            return db.SanBays.Where(p => p.MaSbay == maSbaydi && p.MaSbay == maSbayden).Select(p => new
            {
                MaSbay = p.MaSbay,
                TenSbay = p.TenSbay,
                TenTinhThanh = p.TenTinhThanh
            }).ToList();
        }

        public dynamic findAll()
        {
            return db.SanBays.Select(p => new
            {
                MaSbay=p.MaSbay,
                TenSbay=p.TenSbay,
                TenTinhThanh=p.TenTinhThanh,
            }).ToList();
        }
    }
}
