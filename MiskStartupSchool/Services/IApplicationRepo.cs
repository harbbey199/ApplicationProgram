﻿using Microsoft.AspNetCore.Mvc;
using ApplicationProgram.DTO;

namespace ApplicationProgram.Services
{
    public interface IApplicationRepo
    {
        Task<ProgramDto> GetProgram(string Id);
        Task<List<ProgramDto>> GetAllProgram();
        Task<bool> UpdateProgram(ProgramDto program, string Id);
        Task<string> Add(ApplicationDto application);
        Task<bool> Remove(string Id);
    }
}
