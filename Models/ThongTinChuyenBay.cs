using System;
using System.Collections.Generic;

namespace DOANDATVEMAYBAY2023.Models;

public partial class ThongTinChuyenBay
{
    public string MaCb { get; set; } = null!;

    public string? TenCb { get; set; }

    public DateTime? NgayCatCanh { get; set; }

    public TimeSpan? GioCatCanh { get; set; }

    public DateTime? NgayHaCanh { get; set; }

    public TimeSpan? GioHaCanh { get; set; }

    public string? MaSbayDi { get; set; }

    public string? MaSbayDen { get; set; }

    public string? MaVe { get; set; }

    public string? GheLoai1 { get; set; }

    public string? GheLoai2 { get; set; }

    public int? GiaGheLoai1 { get; set; }

    public int? GiaGheLoai2 { get; set; }

    public virtual SanBay? MaSbayDenNavigation { get; set; }

    public virtual SanBay? MaSbayDiNavigation { get; set; }

    public virtual Ve? MaVeNavigation { get; set; }
}
