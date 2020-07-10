using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ServiceExample.Contracts.Request;
using ServiceExample.Contracts.Response;
using ServiceExample.Domain;
using ServiceExample.Services;
using System.Collections.Generic;

namespace ServiceExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UsersController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var users = _userService.GetUsers();

            return Ok(new Response<List<UserResponse>>(
                _mapper.Map<List<UserResponse>>(users)));
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateUserRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var newUser = _mapper.Map<User>(request);

            _userService.CreateUser(newUser);

            return Created("", new Response<UserResponse>(
                _mapper.Map<UserResponse>(newUser)));
        }
    }
}
