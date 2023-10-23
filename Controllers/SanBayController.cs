using DOANDATVEMAYBAY2023.Services;
using Microsoft.AspNetCore.Mvc;

namespace DOANDATVEMAYBAY2023.Controllers
{
    [Route("api/sanbay")]
    public class SanBayController : Controller
    {
        private SanBayService sanBayService;
        public SanBayController(SanBayService _sanBayService)
        {
            this.sanBayService = _sanBayService;
        }
        [Produces("application/json")]
        [HttpGet("findAll")]
        public IActionResult findAll()
        {
            try
            {
                return Ok(sanBayService.findAll());

            }
            catch
            {
                return BadRequest();
            }
        }
        [Produces("application/json")]
        [Route("find/{maSbaydi}/{maSbayden}")]
        public IActionResult find(string maSbaydi, string maSbayden)
        {
            try
            {
                return Ok(sanBayService.find(maSbaydi,maSbayden));
            }
            catch
            {
                return BadRequest();
            }


        }
    }
}
