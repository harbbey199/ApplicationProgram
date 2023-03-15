using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApplicationProgram.DTO;
using ApplicationProgram.Entities;
using ApplicationProgram.Services;

namespace ApplicationProgram.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppTemplateController : ControllerBase
    {
        private readonly IAppTemplate _temp;

        public AppTemplateController(IAppTemplate temp)
        {
            _temp = temp;
        }

        [HttpGet("get-template")]
        public async Task<IActionResult> GetAppTemp(string Id)
        {
            var data = await _temp.GetTemplate(Id);
            return Ok(data);
        }

        [HttpPut("update-template")]
        public async Task<IActionResult> UpdateWorkflow(AppTemplateDto program, string Id)
        {
            var data = await _temp.UpdateTemplate(program, Id);
            return data ? Ok(StatusCode(200)) : BadRequest(StatusCode(404));
        }
    }
}
