
namespace blakeslist.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BlakesController : ControllerBase
    {
        private readonly BlakesService _blakesService;

        public BlakesController(BlakesService blakesService)
        {
            _blakesService = blakesService;
        }

        [HttpGet]
        public ActionResult<List<Blake>> GetBlakes()
        {
            try
            {
                List<Blake> blakes = _blakesService.GetBlakes();
                return Ok(blakes);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }


        [HttpGet("{blakeId}")]
        public ActionResult<Blake> GetBlakeById(int blakeId)
        {
            try
            {
                Blake blake = _blakesService.GetBlakeById(blakeId);
                return Ok(blake);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public ActionResult<Blake> CreateBlake([FromBody] Blake blakeData)
        {
            try
            {
                Blake blake = _blakesService.CreateBlake(blakeData);
                return Ok(blake);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }


        [HttpDelete("{blakeId}")]
        public ActionResult<string> DestroyBlake(int blakeId)
        {
            try
            {
                string message = _blakesService.DestroyBlake(blakeId);
                return Ok(message);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }



        [HttpPut("{blakeId}")]
        public ActionResult<Blake> UpdateBlake(int blakeId, [FromBody] Blake blakeData)
        {
            try
            {
                Blake blake = _blakesService.UpdateBlake(blakeId, blakeData);
                return Ok(blake);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}