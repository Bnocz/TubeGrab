using MagicTube.Data;
using MagicTube.Models;
using MagicTube.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace MagicTube.Controllers
{
    [Route("api/TubeGetAPI")]
    [ApiController]
    public class TubeGetController : ControllerBase
    {
        [HttpGet]
        public ActionResult IEnumerable<VillaDTO> GetVillas()
        {
            return Ok(VillaStore.villaList);
            
        }

        [HttpGet("id")]
        public VillaDTO GetVilla(int id)

        {
            return VillaStore.villaList.FirstOrDefault(u => u.Id==id);

        }

    }
}
