using Microsoft.AspNetCore.Mvc;
using Scientific_Research_Center.Core.Interfaces;

namespace Scientific_Research_Center.API.Controllers;

public abstract class ClinicController<T> : ControllerBase where T : class
{
    protected IService<T> Service;
    private ILogger<ClinicController<T>> _logger;

    public ClinicController(IService<T> service, ILogger<ClinicController<T>> logger)
    {
        Service = service;
        _logger = logger;
    }
    
    [HttpGet("get")]
    public IActionResult Get(int id)
    {
        T? entity = Service.Get(id);
        return entity is not null ? Ok(entity) : NotFound();
    }

    [HttpPost("update")]
    public async Task<IActionResult> Update(T entity)
    {
        await Service.Update(entity);
        return Ok();
    }

    [HttpDelete("delete")]
    public async Task<IActionResult> Delete(int id)
    {
        await Service.Delete(id);
        return Ok();
    }

    [HttpPost("add")]
    public async Task<IActionResult> Add(T entity)
    {
        await Service.Add(entity);
        return Ok();
    }
}