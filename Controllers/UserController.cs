using cty.Interfaces;
using cty.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cty.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserModels _adminSvc;
        public UserController(IUserModels adminSvc)
        {
            _adminSvc = adminSvc;

        }


        [HttpGet]
        [ActionName("get")]
        public async Task<ActionResult<IEnumerable<UserModel>>> GetUserModelAll()
        {
            return  await _adminSvc.GetAllUserModel();
            
        }

        [HttpPost]
        [ActionName("create")]
        public async Task<ActionResult> AddUser(UserModel user)
        {
            try
            {
                int id = await _adminSvc.AddUserModel(user);
                user.User_ID = id;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok(1);
        }

        [HttpPost]
        [ActionName("update")]
        public async Task<ActionResult> UpdateUser(int id, UserModel user)
        {
            try
            {
                await _adminSvc.EditUserModel(id, user);
                user.User_ID = id;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok(1);
        }

        [HttpDelete("{id}")]
        [ActionName("delete")]
        public async Task<ActionResult<int>> DeleteUser(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            try
            {
                await _adminSvc.DeleteUserModel(id);

            }
            catch (Exception ex)
            {
                return BadRequest(-1);
            }

            return Ok(1);
        }
    }
}
