using BA2.Data;
using BA2.Entity;
using Microsoft.EntityFrameworkCore;

namespace BA2.Services
{
    public class PrandService : IPrandService
    {
        private readonly DataContext _DB; 
        public PrandService(DataContext context)
        {
            _DB = context;
        }

        public async Task<Prand>  CreatePrand(Prand prand)
        {
             _DB.Prands.Add(prand);
            await _DB.SaveChangesAsync();
            return prand;
        }

        public async Task<bool> DeletePrand(int id)
        {
            var prand = await  _DB.Prands.FindAsync(id);
            if(prand != null)
            {
                _DB.Remove(prand);
                await _DB.SaveChangesAsync();
                return true; 
            }
            return false;

        }

        public async Task<Prand> EditPrand(int id, Prand prand)
        {
            var pr = await _DB.Prands.FindAsync(id);
            if(pr != null)
            {
                pr.Name = prand.Name;
                pr.City = prand.City;
                await _DB.SaveChangesAsync();
                return pr;

            }
            throw new Exception("somthing wrong!!");

        }

        public async Task<Prand> GetPrandByID(int id)
        {
            var prand = await _DB.Prands.FindAsync(id);
            if(prand != null)
                return prand;
            throw new Exception("prand not dound");
        }

        public async Task<List<Prand>> GetPrandList() =>  await _DB.Prands.ToListAsync();

    }
}
