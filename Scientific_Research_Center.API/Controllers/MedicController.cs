using Microsoft.AspNetCore.Mvc;
using Scientific_Research_Center.API.DTOs;
using Scientific_Research_Center.API.Helpers;
using Scientific_Research_Center.API.Models;
using Scientific_Research_Center.Core.Interfaces;
using Scientific_Research_Center.Core.Models;

namespace Scientific_Research_Center.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MedicController : ClinicController<Medic>
{
    public MedicController(IService<Medic> service, ILogger<ClinicController<Medic>> logger) : base(service, logger)
    {
    }
    
    [HttpGet("getPage")]
    public new IActionResult Get(int page=1)
    {
        List<MedicDto> medicDtos = new();
        var medics = Service.Get()
            .Skip(PageInfo.PageSize * (page-1))
            .Take(PageInfo.PageSize)
            .ToList();

        medics.ForEach(m => medicDtos.Add(m.ToDto()));

        return Ok(medicDtos);
    }
}