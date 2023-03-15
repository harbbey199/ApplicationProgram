using ApplicationProgram.DTO;

namespace ApplicationProgram.Services
{
    public interface IWorkflowRepo
    {
        Task<WorkflowDto> GetWorkflow(string Id);
        Task<bool> UpdateWorkflow(WorkflowDto program, string Id);
    }
}
