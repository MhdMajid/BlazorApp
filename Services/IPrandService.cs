using BA2.Entity;

namespace BA2.Services
{
    public interface IPrandService
    {
        Task<Prand> CreatePrand(Prand prand);
        Task <List<Prand>> GetPrandList ();
        Task<Prand> GetPrandByID(int id);
        Task<Prand> EditPrand(int id, Prand prand);
        Task<bool> DeletePrand(int id);

    }
}
