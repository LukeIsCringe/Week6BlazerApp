using Microsoft.EntityFrameworkCore;
using Week6BlazerApp.Data;
using Week6BlazerApp.Data.Models;

namespace Week6BlazerApp.Services
{
    public class ModuleService
    {
        IDbContextFactory<ApplicationDbContext> contextFactory;

        public ModuleService(IDbContextFactory<ApplicationDbContext> contextFactory)
        {
            this.contextFactory = contextFactory;
        }
        
        public void Add(Module module)
        {
            using (var context = contextFactory.CreateDbContext())
            {
                //Add module to the dataset
                context.Modules.Add(module);

                //Cascade changes to the database
                context.SaveChanges();
            }
        }
    }
}
