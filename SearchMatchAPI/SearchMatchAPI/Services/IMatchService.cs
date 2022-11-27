using SearchMatchAPI.DTOs;
using SearchMatchAPI.Models;

namespace SearchMatchAPI.Services
{
    public interface IMatchService
    {
        Task Match(int searchID,Patient patient);
    }
}
