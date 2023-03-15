using ApplicationProgram.DTO;

namespace ApplicationProgram.Services
{
    public interface IAppTemplate
    {
        Task<AppTemplateDto> GetTemplate(string Id);
        Task<bool> UpdateTemplate(AppTemplateDto program, string Id);
    }
}
