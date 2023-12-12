using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TOCOMA_API_Service.Service;
using TOCOMA_ERP_ClassLibrary.Models;

namespace TOCOMA_API_Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private AuthenticationService authService;
        public AuthenticationController(AuthenticationService _authService)
        {
            authService = _authService;

        }
        [HttpPost]
        [Route("UserLogin")]
        public UserModel AdminLogin(UserModel userModel)
        {
            return authService.GetUserInfo(userModel);
        }
        [HttpGet]
        [Route("GetExistingUser/{emailId}")]
        public bool GetExistingUserByEmail(string emailId)
        {
            return authService.GetExistingUserByEmailId(emailId);
        }
        [HttpPost]
        [Route("CreateUser")]
        public bool CreateUser([FromBody] UserModel user)
        { return authService.CreateUser(user); }
    }
}
