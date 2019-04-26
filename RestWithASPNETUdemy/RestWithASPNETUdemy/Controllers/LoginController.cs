using Microsoft.AspNetCore.Mvc;
using RestWithASPNETUdemy.Business;
using Microsoft.AspNetCore.Authorization;
using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Data.VO;

namespace RestWithASPNETUdemy.Controllers
{
    [ApiVersion("1")]
    [Route("api/[controller]/v{version:apiVersion}")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private ILoginBusiness _loginBusiness;

        public LoginController(ILoginBusiness loginBusiness)
        {
            _loginBusiness = loginBusiness;
        }

        // POST api/values
        [AllowAnonymous]
        [HttpPost]
        public object Post([FromBody] UserVO user)
        {
            if (user == null) return BadRequest();

            return _loginBusiness.FindByLogin(user);
        }

    }
}
