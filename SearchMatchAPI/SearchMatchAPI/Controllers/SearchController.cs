
using Microsoft.AspNetCore.Mvc;
using SearchMatchAPI.DTOs;
using SearchMatchAPI.Models;
using SearchMatchAPI.Repositories;
using SearchMatchAPI.Services;

namespace SearchMatchAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SearchController : ControllerBase
    {
        private readonly IPatientRepository repository;
        private readonly IMatchService matchService;
        public SearchController(IPatientRepository repository, IMatchService matchService )
        {
            this.repository = repository ??
                throw new ArgumentNullException(nameof(repository));
            this.matchService = matchService ??
                throw new ArgumentNullException(nameof(matchService));
        }

        [HttpPost]
        public async Task<IActionResult> CreateSearch(SearchDTO searchDTO)
        {
            if (searchDTO == null)
                return BadRequest("Search error!");

            var patient = repository.GetPatient(searchDTO.PatientID);
            if (patient is null) { return NotFound("Patient id does not exist!"); }

            try
            {
                await matchService.Match(searchDTO.MatchEngineID, patient);
            }
            catch(ArgumentOutOfRangeException ex) { return NotFound("Search engine id does not exist!"); }
            return Ok();
        }


    }
}
