using System;
using System.Collections.Generic;

namespace DOANDATVEMAYBAY2023.Models;

public partial class Ve
{
    public string MaVe { get; set; } = null!;

    public DateTime? ThoiGianDat { get; set; }

    public DateTime? ThoiGianDi { get; set; }

    public string? LoaiGhe { get; set; }

    public int? GiaGhe { get; set; }

    public string? MaHk { get; set; }

    public virtual HanhKhach? MaHkNavigation { get; set; }

    public virtual ICollection<ThongTinChuyenBay> ThongTinChuyenBays { get; set; } = new List<ThongTinChuyenBay>();
}
