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
    public class RoleController : ControllerBase
    {
        private readonly IRole _role;
        public RoleController(IRole role)
        {
            _role = role;

        }

        [HttpGet]
        [ActionName("get-role")]
        public async Task<ActionResult<IEnumerable<Roles>>> GetAllRole()
        {
            var list = await _role.GetAllRole();
            return list;
        }


        [HttpPost]
        [ActionName("create")]
        public async Task<ActionResult> AddRole(Roles role)
        {
            try
            {
                int id = await _role.AddRole(role);
                role.Id = id;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok(1);
        }

        [HttpPost]
        [ActionName("update-role")]
        public async Task<ActionResult> UpdateRole(int id, Roles role)
        {
            try
            {
                 await _role.EditRole(id ,role);
                role.Id = id;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok(1);
        }

        [HttpDelete("{id}")]
        [ActionName("delete")]
        public async Task<ActionResult<int>> DeleteRole(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            try
            {
                await _role.DeleteRole(id);

            }
            catch (Exception ex)
            {
                return BadRequest(-1);
            }

            return Ok(1);
        }
    }
}
