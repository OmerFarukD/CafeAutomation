using Application.Features.Categories.Commands.Create;
using Application.Features.Categories.Commands.Update;
using Application.Features.Categories.Dtos.Requests;
using Application.Features.Categories.Queries.GetById;
using Application.Features.Categories.Queries.GetList;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Web.API.Controllers;
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController(IMediator mediator) : ControllerBase
    {
        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] CreateCategoryRequestDto dto)
        {
            var response = await mediator.Send(new CreateCategory.Command(dto));
            return StatusCode(response.StatusCode, response.Data);
        }

        [HttpGet("getall")]
        public async Task<IActionResult> GetAll()
        {
            var response = await mediator.Send(new GetListCategory.Query());
            return StatusCode(response.StatusCode, response.Data);
        }

        [HttpGet("getbyid")]
        public async Task<IActionResult> GetById([FromQuery] Guid id)
        {
            var response = await mediator.Send(new GetByIdCategory.Query(id));
            return StatusCode(response.StatusCode, response.Data);
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody] UpdateCategoryRequestDto dto)
        {
            var response = await mediator.Send(new UpdateCategory.Command(dto));
            return StatusCode(response.StatusCode, response.Data);
        }
    }

