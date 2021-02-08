

using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class CompaniesController : ControllerBase
  {
    private readonly ICompanyRepository _repo;
    public CompaniesController(ICompanyRepository repo)
    {
      _repo = repo;
    }

    [HttpGet]
    public async Task<ActionResult<IReadOnlyList<Company>>> GetCompanies()
    {
      return Ok(await _repo.GetCompaniesAsync());
    }
    [HttpGet("{id}")]
    public async Task<ActionResult<Company>> GetCompany(int id)
    {
      return Ok(await _repo.GetCompanyByIdAsync(id));
    }
    [HttpGet("sizes")]
    public async Task<ActionResult<IReadOnlyList<CompanySize>>> GetCompanySizes()
    {
        return  Ok(await _repo.GetCompanySizesAsync());
    }
    [HttpGet("types")]
    public async Task<ActionResult<IReadOnlyList<CompanySize>>> GetCompanyTypes()
    {
        return  Ok(await _repo.GetCompanyTypesAsync());
    }
  }
}