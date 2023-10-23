using System;
using System.Collections.Generic;

namespace DOANDATVEMAYBAY2023.Models;

public partial class AdminUser
{
    public string Id { get; set; } = null!;

    public string? TaiKhoan { get; set; }

    public string? MatKhau { get; set; }
}
