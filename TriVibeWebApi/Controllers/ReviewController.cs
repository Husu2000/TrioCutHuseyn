using Microsoft.AspNetCore.Mvc;
using TriVibe.Application.CQRS.Reviews.Command.Request;
using TriVibe.Application.CQRS.Reviews.Query.Request;

namespace TriVibeWebApi.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class ReviewController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> AddReview(AddReviewCommandRequest request)
    {
        return Ok(await Sender.Send(request));
    }

    [HttpPut]
    public async Task<IActionResult> UpdateReview(UpdateReviewCommandRequest request)
    {
        return Ok(await Sender.Send(request));
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteReview(DeleteReviewCommandRequest request)
    {
        return Ok(await Sender.Send(request));
    }

    [HttpGet]
    public async Task<IActionResult> GetAllReviews([FromQuery] GetAllReviewsQueryRequest request)
    {
        return Ok(await Sender.Send(request));
    }
}
