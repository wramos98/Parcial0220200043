using Microsoft.EntityFrameworkCore;

namespace Parcial0220200043.API.Models
{
    public class TerritoryRepository : ITerritoryRepository
    {
        private readonly Dpa202302parcialCaso0220200043Context _context;
        public TerritoryRepository(Dpa202302parcialCaso0220200043Context context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Territory>> GetTerritory()
        {
            var territory = await _context.Territory.ToListAsync();
            return territory;

        }

        public async Task<bool> Insert(Territory territory)
        {
            await _context.Territory.AddAsync(territory);
            var countRows = await _context.SaveChangesAsync();
            return (countRows > 0);
        }

        public async Task<bool> Update(Territory territory)
        {
            _context.Territory.Update(territory);
            var countRows = await _context.SaveChangesAsync();
            return (countRows > 0);
        }

        public async Task<bool> Delete(int id)
        {
            var territory = await _context.Territory.FindAsync(id);
            return (territory != null);
        }

        public Task<IEnumerable<Territory>> GetUsers()
        {
            throw new NotImplementedException();
        }
    }
}
