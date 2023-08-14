
namespace chore_score.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChoresController : ControllerBase
    {
        private readonly ChoresService _choresService;

        public ChoresController(ChoresService choresService)
        {
            _choresService = choresService;
        }

        [HttpGet]
        public ActionResult<List<Chore>> GetChores()
        {
            try
            {
                List<Chore> chores = _choresService.GetChores();
                return Ok(chores);
            }
            catch (Exception e)
            {
                
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{choreName}")]
        public ActionResult<Chore> GetChoreByName(string choreName)
        {
            try
            {
                Chore chore = _choresService.GetChoreByName(choreName);
                return Ok(chore);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}