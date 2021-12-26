using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SelectBoxAPI.Interfaces;

namespace SelectBoxAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SectorsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public SectorsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Sectors
        [HttpGet]
        public async Task<ActionResult<string[]>> GetSectors()
        {

            var sectors = await _unitOfWork.Sectors.GetSectorsAsyncAsStringArray();

            if (sectors == null)
            {
                return NotFound();
            }

            return Ok(sectors);

        }


    }
}
