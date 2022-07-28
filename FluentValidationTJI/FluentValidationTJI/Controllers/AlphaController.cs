using FluentValidationTJI.Managers.Interfaces;
using FluentValidationTJI.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace FluentValidationTJI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlphaController : ControllerBase
    {
        private readonly IAlphaManager _alphaManager;

        public AlphaController(IAlphaManager alphaManager)
        {
            _alphaManager = alphaManager;
        }

        [HttpGet("GetAlpha")]
        public async Task<IActionResult> Get()
        {
            var result = await _alphaManager.GetAsync();
            return Ok(result);
        }

        [HttpGet("GetAlphaById")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _alphaManager.GetByIdAsync(id);
            return Ok(result);
        }

        [HttpPut("CreateAlpha")]
        public async Task<IActionResult> Create([FromBody] AlphaDto obj)
        {
            var result = await _alphaManager.CreateAsync(obj);
            return Ok(result);
        }

        [HttpPost("UpdateAlpha")]
        public async Task<IActionResult> Update([FromBody] AlphaDto obj)
        {
            var result = await _alphaManager.UpdateAsync(obj);
            return Ok(result);
        }

        [HttpDelete("Delete")]
        public async Task<int> Delete(int id)
        {
            return await _alphaManager.DeleteAsync(id);
        }
    }
}
