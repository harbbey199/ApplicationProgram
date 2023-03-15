using ApplicationProgram.Entities;

namespace ApplicationProgram.DTO
{
    public class WorkflowDto 
    {
        public ICollection<Stage> stages { get; set; }
    }
}
