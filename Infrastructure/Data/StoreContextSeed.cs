using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Data
{
    public class StoreContextSeed
    {
        public static async Task SeedAsync(StoreContext context, ILoggerFactory loggerFactory){
            try{
                if(!context.CompanySizes.Any())
                {
                    var sizesData = File.ReadAllText("../Infrastructure/Data/SeedData/companysizes.json");
                    var sizes = JsonSerializer.Deserialize<List<CompanySize>>(sizesData); 
                    foreach(var item in sizes){
                        context.CompanySizes.Add(item);   
                    }
                }
                await context.SaveChangesAsync();

                if(!context.CompanyTypes.Any())
                {
                    var typesData = File.ReadAllText("../Infrastructure/Data/SeedData/companytypes.json");
                    var types = JsonSerializer.Deserialize<List<CompanyType>>(typesData); 
                    foreach(var item in types){
                        context.CompanyTypes.Add(item);   
                    }
                }
                await context.SaveChangesAsync();

                if(!context.Companies.Any())
                {
                    var companiesData = File.ReadAllText("../Infrastructure/Data/SeedData/companies.json");
                    var companies = JsonSerializer.Deserialize<List<Company>>(companiesData); 
                    foreach(var item in companies){
                        context.Companies.Add(item);   
                    }
                }
                await context.SaveChangesAsync();
            }
            catch(Exception ex){
                var logger = loggerFactory.CreateLogger<StoreContextSeed>();
                logger.LogError(ex.Message);
            }
        }
    }
}