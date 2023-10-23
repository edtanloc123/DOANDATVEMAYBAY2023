using System;
using System.Collections.Generic;

namespace DOANDATVEMAYBAY2023.Models;

public partial class HanhKhach
{
    public string MaHk { get; set; } = null!;

    public string? TenKhachHang { get; set; }

    public DateTime? NgaySinh { get; set; }

    public string? SoDienThoai { get; set; }

    public string? GioiTinh { get; set; }

    public virtual ICollection<Ve> Ves { get; set; } = new List<Ve>();
}
