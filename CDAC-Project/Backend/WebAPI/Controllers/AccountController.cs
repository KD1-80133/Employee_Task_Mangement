﻿using EnitityModelLib;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using RepositoryLib;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebAPI.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("/user")]
    [ApiController]


    public class AccountController : ControllerBase
    {
        IConfiguration config;

        MembershipRepository service;
        public AccountController(IConfiguration config)
        {
            this.config = config;
            service = new MembershipRepository();
        }
        // GET: api/<AccountController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<AccountController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
        // POST api/<AccountController>
        [HttpPost]
        [AllowAnonymous]

        [Route("/User/Login")]

        public IActionResult Post([FromBody] Login value)
        {
            try
            {
                Console.WriteLine($"Received email: {value.EmailId}, password: {value.Password}");

                IActionResult response = Unauthorized();
                bool result = false;

                if (ModelState.IsValid)
                {
                    result = service.ValidateUser(value.EmailId, value.Password);

                    if (result)
                    {
                        var token = GenerateJwtToken(value.EmailId);
                        return Ok(new { Token = token });
                    }
                    else
                    {
                        Console.WriteLine("Validation failed: Invalid credentials");
                    }
                }
                else
                {
                    Console.WriteLine("ModelState is not valid");
                }

                return response;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in Post method: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }


        private string GenerateJwtToken(string email)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
            new Claim(JwtRegisteredClaimNames.Sub, email),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            
        };

            var token = new JwtSecurityToken(
                config["Jwt:Issuer"],
                config["Jwt:Audience"],
                claims,
                expires: DateTime.Now.AddMinutes(15),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    

    
    [HttpPost]
        [Route("/User/Signup")]
        public bool Post([FromBody] Signup value)
        {
            bool result = false;
            if (ModelState.IsValid)
            {
                result = service.CreateUser(value.userName, value.password, value.mobileNo, value.emailId,value.RoleId);
                return true;
            }
            return result;
        }
        //RESET USER
        [HttpPost]
        [Route("Reset")]
        public bool Post([FromBody] ResetPassword value)
        {
            bool result = false;
            if (ModelState.IsValid)
            {
                result = service.ResetPassword(value.EmailId, value.OTP, value.Password);
            }
            return result;
        }

        //GENERATE OTP
        [HttpPost()]
        [Route("GenerateOTP")]
        public string Post([FromBody] GenerateOTP value)
        {
            string result = "";
            if (ModelState.IsValid)
            {
                string otp = service.GenerateOTP(value.EmailId);
            }
            return result;
        }


        //CHANGE PASSWORD   
        [HttpPost]
        [Route("ChangePassword")]
        public bool Post([FromBody] ChangePassword value)
        {
            bool result = true;
            if (ModelState.IsValid)
            {
                result = service.ChangePassword(value.EmailId, value.OldPassword, value.NewPassword);

            }
            return result;
        }
        // PUT api/<AccountController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        //DELETE USER
        // DELETE api/<AccountController>/EmailId
        [HttpDelete("{EmailId}")]
        public bool Delete(string EmailId)
        {
            bool result = false;
            if (ModelState.IsValid)
            {
                result = service.DeleteUser(EmailId);
            }
            return result;
        }
    }
}
