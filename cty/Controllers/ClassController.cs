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
    public class ClassController : ControllerBase
    {
        private readonly ICLass _class;
        public ClassController(ICLass lop)
        {
            _class = lop;
        }
        [HttpGet]
        [ActionName("get")]
        public async Task<ActionResult<IEnumerable<LopHoc>>> GetCkassAll()
        {
            var list = await _class.GetAllClass();
            return list;
        }

        [HttpPost]
        [ActionName("create")]
        public async Task<ActionResult> AddClass(LopHoc lophoc)
        {
            try
            {
                int id = await _class.AddClass(lophoc);
                lophoc.ID_CLass = id;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok(1);
        }

        [HttpPost]
        [ActionName("update")]
        public async Task<ActionResult> UpdateClass(int id, LopHoc lophoc)
        {
            try
            {
                await _class.EditClass(id, lophoc);
                lophoc.ID_CLassId = id;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok(1);
        }

        [HttpDelete("{id}")]
        [ActionName("delete")]
        public async Task<ActionResult<int>> DeleteClass(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            try
            {
                await _class.DeleteClass(id);

            }
            catch (Exception ex)
            {
                return BadRequest(-1);
            }

            return Ok(1);
        }
    }
}
