using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain_Models.Models;
using DTO_Models;
using DTO_Models.ApiModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace MilanEmailWebApiApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase

    {

        private IUserService _userService;

        public UserController(IUserService userService) 
        {
            _userService = userService;
        }
        // GET: api/User
        [HttpGet]
        public ActionResult<List<User>> Get()
        {
            try
            {
                var users = _userService.GetAllUsers();
                return Ok(users);
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // GET: api/User/5
        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            try 
            {
                // If Id is greater than what is stored. Converting 204 NoContent request with BadRequest
                var user = _userService.GetUserById(id);
                if (user == null) return BadRequest("Invalid User ID. Such user was never found");

                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPost("login")]
        public ActionResult<UserModel> LogIn([FromBody] LoginModel loginModel)
        {
            try 
            {
                var userModel = _userService.Authenticate(loginModel);
                return Ok(userModel);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }

        }

        // POST: api/User
        [HttpPost]
        public ActionResult Post([FromBody] RegisterModel user)
        {
            try
            {
                _userService.AddUser(user);
                return Ok("Creating user successful!");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // PUT: api/User/5
        [HttpPut]
        public ActionResult Put( [FromBody] UserModel user)
        {
            try
            {
                _userService.UpdateUser(user);
                return Ok("User was updated successfully");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("id")]
        public ActionResult Delete(int id)
        {
            try
            {
                _userService.DeleteUser(id);
                return Ok("User was removed! ");
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
