using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface ICompanyRepository
    {
         Task<Company> GetCompanyByIdAsync(int id);
         Task<IReadOnlyList<Company>> GetCompaniesAsync();
         Task<IReadOnlyList<CompanySize>> GetCompanySizesAsync();
         Task<IReadOnlyList<CompanyType>> GetCompanyTypesAsync();
    }
}