using DOANDATVEMAYBAY2023.Models;

namespace DOANDATVEMAYBAY2023.Services
{
    public class ThongTinChuyenBayServiceImpl : ThongTinChuyenBayService
    {
        private DatabaseContext db;
        private IConfiguration configuration;
        public ThongTinChuyenBayServiceImpl(DatabaseContext _db,IConfiguration _configuration)
        {
            this.db = _db;
            this.configuration = _configuration;
        }

        public dynamic find(string MaSbay)
        {
            return db.ThongTinChuyenBays.Find(MaSbay);
        }

        public dynamic findAll()
        {
            return db.ThongTinChuyenBays.Select(p => new 
            {
                MaCb=p.MaCb,
                TenCb=p.TenCb,
                NgayCatCanh = p.NgayCatCanh,
                GioCatCanh=p.GioCatCanh,
                NgayHaCanh=p.NgayHaCanh,
                GioHaCanh=p.GioHaCanh,
                MaSbayDi = p.MaSbayDiNavigation.MaSbay,
                MaSbayDen= p.MaSbayDenNavigation.MaSbay,
                TenTinhThanhSanBayDi=p.MaSbayDiNavigation.TenTinhThanh,
                TenTinhThanhSanBayDen = p.MaSbayDenNavigation.TenTinhThanh,
                MaVe =p.MaVe,
                GheLoai1=p.GheLoai1,
                GheLoai2=p.GheLoai2,
                GiaGheLoai1=p.GiaGheLoai1,
                GiaGheLoai2=p.GiaGheLoai2,
            }).ToList();
        }
    }
    /*  MaSbayDi=p.MaSbayDiNavigation.MaSbay,
                MaSbayDen= p.MaSbayDenNavigation.MaSbay*/
}
