using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApplicationProgram.DTO;
using ApplicationProgram.Services;

namespace ApplicationProgram.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkflowController : ControllerBase
    {
        private readonly IWorkflowRepo _workflow;

        public WorkflowController(IWorkflowRepo workflow)
        {
            _workflow = workflow;
        }

        [HttpGet("get-workflow")]
        public async Task<IActionResult> GetWorkflow(string Id)
        {
            var data = await _workflow.GetWorkflow(Id);
            return Ok(data);
        }

        [HttpPut("update-workflow")]
        public async Task<IActionResult> UpdateWorkflow(WorkflowDto program, string Id)
        {
            var data = await _workflow.UpdateWorkflow(program, Id);
            return data ? Ok(StatusCode(200)) : BadRequest(StatusCode(404));
        }
    }
}
