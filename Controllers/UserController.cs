

namespace BrotaAPIAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class UserController : ControllerBase
    {
        private readonly IUserService UserService;

        public UserController(IUserService userService) 
            => (UserService) = (userService);

        [HttpPost]
        public async Task<IActionResult> CreateUser(User user)
        {
            
            if (user == null)
            {
                return BadRequest("Verifique os dados cadastrados");
            }

            try { 
                var newUser = await UserService.CreateUser(user);
                return Ok(newUser);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
    }
}
