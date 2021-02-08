using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
  public class CompanyRepository : ICompanyRepository
  {
    private readonly StoreContext _context;
    public CompanyRepository(StoreContext context)
    {
      _context = context;
    }

    public async Task<IReadOnlyList<Company>> GetCompaniesAsync()
    {
      return await _context.Companies
        .Include(p => p.CompanySize)
        .Include(p => p.CompanyType)
        .ToListAsync();
    }

    public async Task<Company> GetCompanyByIdAsync(int id)
    {
      return await _context.Companies
        .Include(p => p.CompanySize)
        .Include(p => p.CompanyType)
        .FirstOrDefaultAsync(p => p.Id == id);
    }
 
    public async Task<IReadOnlyList<CompanySize>> GetCompanySizesAsync()
    {
      return await _context.CompanySizes.ToListAsync();
    }

    public async Task<IReadOnlyList<CompanyType>> GetCompanyTypesAsync()
    {
      return await _context.CompanyTypes.ToListAsync();
    }
  }
}