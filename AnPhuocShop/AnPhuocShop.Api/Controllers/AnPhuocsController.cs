using AnPhuocShop.Api.Models;
using AnPhuocShop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnPhuocShop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnPhuocsController : ControllerBase
    {
        private readonly IAnPhuocRepository anPhuocRepository;
        public AnPhuocsController(IAnPhuocRepository anPhuocRepository)
        {
            this.anPhuocRepository = anPhuocRepository;
        }
        [HttpGet]//Dùng httpget để goi trình duyệt web
        public async Task<ActionResult<IEnumerable<AnPhuoc>>> GetAnPhuocs()
        {
            try
            {
                return (await anPhuocRepository.GetAnPhuocs()).ToList();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Lỗi khi truy xuất dữ liệu từ cơ sở dữ liệu");//hiện ra khi gặp lỗi ngoại lệ
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<AnPhuoc>> GetAnPhuoc(int id)
        {
            try
            {
                var result = await anPhuocRepository.GetAnPhuoc(id);
                if (result == null)
                {
                    return NotFound();
                }

                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Loi tu server");
            }
        }

        [HttpPost]
        public async Task<ActionResult<AnPhuoc>> CreateAnPhuoc(AnPhuoc anPhuoc)
        {
            try
            {
                if (anPhuoc == null)
                    return BadRequest();
                var createAnPhuoc = await anPhuocRepository.AddAnPhuoc(anPhuoc);

                return CreatedAtAction(nameof(GetAnPhuoc),
                    new { id = createAnPhuoc.AnPhuocId }, createAnPhuoc);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Loi khi them san pham moi");
            }
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<AnPhuoc>> UpdateAnPhuoc(int id, AnPhuoc anphuoc)
        {
            try
            {
                if (id != anphuoc.AnPhuocId)
                    return BadRequest("Ma ID khong khop");
                var anphuocToUpdate = await anPhuocRepository.GetAnPhuoc(id);
                if (anphuocToUpdate == null)
                    return NotFound($"Khong tim thay san pham Id = {id}");
                return await anPhuocRepository.UpdateAnPhuoc(anphuoc);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Loi cap nhat du lieu");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<AnPhuoc>> DeleteAnPhuoc(int id)
        {
            try
            {
                var anphuocToDelete = await anPhuocRepository.GetAnPhuoc(id);
                if (anphuocToDelete == null)
                {
                    return NotFound($"Khong tim thay san pham co Id = {id}");
                }
                return await anPhuocRepository.DeleteAnPhuoc(id);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Loi khi xoa du lieu");
            }
        }

        [HttpGet("{search}")]
        public async Task<ActionResult<IEnumerable<AnPhuoc>>> DeleteAnPhuoc (string name)
        {
            try
            {
                var result = await anPhuocRepository.Search(name);
                if (result.Any())
                {
                    return Ok(result);
                }
                else
                    return NotFound();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Loi khi lay du lieu tu CSDL");
            }
        }
    }
}
