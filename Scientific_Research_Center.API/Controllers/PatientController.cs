using Microsoft.AspNetCore.Mvc;
using Scientific_Research_Center.API.DTOs;
using Scientific_Research_Center.API.Helpers;
using Scientific_Research_Center.API.Models;
using Scientific_Research_Center.Core.Interfaces;
using Scientific_Research_Center.Core.Models;

namespace Scientific_Research_Center.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PatientController : ClinicController<Patient>
{
    public PatientController(IService<Patient> service, ILogger<ClinicController<Patient>> logger) : base(service, logger)
    {
    }

    [HttpGet("getPage")]
    public new IActionResult Get(int page)
    {
        List<PatientDto> patientDtos = new();
        var patients = Service.Get()
            .Skip(PageInfo.PageSize * (page-1))
            .Take(PageInfo.PageSize)
            .ToList();

        patients.ForEach(p => patientDtos.Add(p.ToDto()));

        return Ok(patientDtos);
    }
}