using api.Application.Dtos;
using api.Application.Repositories;
using api.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace api.Presentation;

[ApiController]
[Route("api/v1/polls")]

public class PollsController(IPollRepository pollRepository, IOptionRepository optionRepository): ControllerBase
{
    [HttpGet()]
    public async Task<IResult> GetAllPolls()
    {
        return Results.Ok(await pollRepository.GetAll());
    }

    [HttpPost()]
    public async Task<IResult> PostPoll([FromBody] CreatePollDto request)
    {
        Poll poll = new()
        {
            Name = request.Name,
            Options = request.Options
        };

        string response = await pollRepository.Create(poll);
        return Results.Ok(response);
    }

    [HttpPost("{pollId:guid}/votes")]
    public async Task<IResult> PostOption(Guid pollId, [FromBody] CreateOptionDto request)
    {
        Option option = new()
        {
            VoterEmail = request.VoterEmail,
            PollId = pollId
        };

        string response = await optionRepository.Create(option);
        return Results.Ok(response);
    }
    
}
