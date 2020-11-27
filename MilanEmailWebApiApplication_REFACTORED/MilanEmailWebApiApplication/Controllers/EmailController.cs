using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Domain_Models.Models;
using DTO_Models.ApiModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace MilanEmailWebApiApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        // !!!! 
        //check whether there is a User with an ID linked to the Email.
        //Need to implement IUserService

        private IEmailService _emailService;
        private IUserService _userService;
        public EmailController (IEmailService emailService, IUserService userService)
        {
            _emailService = emailService;
            _userService = userService;
        }
        // GET: api/Email
        [HttpGet]
        public ActionResult<List<EmailModel>> Get()
        {
            try
            {
                return Ok(_emailService.GetAllEmails());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        // GET: api/Email/5
        [HttpGet("{id}")]
        public ActionResult<EmailModel> Get(int id)
        {
            try
            {
                return Ok(_emailService.GetEmailById(id));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        
        // USING THE USER ID to add the Email
        // Email is locked with User Id as a Key 

        // POST: api/Email/2
        [HttpPost]
        public ActionResult Post([FromQuery] int userId, [FromBody] EmailModel email) //Get the ID from the query request
        {
            try
            {
                // Check if user is existing in database
                //If not a valid user
                var user = _userService.GetUserById(userId);
                if (user == null) throw new Exception("Invalid user ID entered");

                // If the user is valid
                email.UserId = userId;
                
                // Add email 
                _emailService.AddEmail(email);
                return Ok("Email created successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT: api/Email
        [HttpPut]
        public ActionResult Put([FromBody] EmailModel email)
        {
            try
            {
                // Check if there is such email in the database
                var dbEmail = _emailService.GetEmailById(email.Id);
                if (dbEmail == null) throw new Exception("There is no such email to be updated");

                _emailService.UpdateEmail(email);
                return Ok("Email updated successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                _emailService.DeleteEmail(id);
                return Ok("email Deleted Successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
