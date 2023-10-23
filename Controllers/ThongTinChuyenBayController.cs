using DOANDATVEMAYBAY2023.Models;
using DOANDATVEMAYBAY2023.Services;
using Microsoft.AspNetCore.Mvc;

namespace DOANDATVEMAYBAY2023.Controllers
{
    [Route("api/thongtinchuyenbay")]
    public class ThongTinChuyenBayController : Controller
    {

        private ThongTinChuyenBayService thongTinChuyenBayService;
        private SanBayService sanBayService;
        public ThongTinChuyenBayController(ThongTinChuyenBayService _thongTinChuyenBayService, SanBayService sanBayService)
        {
            this.thongTinChuyenBayService = _thongTinChuyenBayService;
            this.sanBayService = sanBayService;
        }
        [Produces("application/json")]
        [HttpGet("findAll")]
        public IActionResult findAll()
        {
            try
            {   
                return Ok(thongTinChuyenBayService.findAll());
            }catch 
            {
                return BadRequest();
            }
        }
    }
}
