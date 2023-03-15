namespace ApplicationProgram.Entities
{
    public class WorkFlow : ProgramTemp
    {
        public ICollection<Stage>? stages { get; set; }

    }
}
