﻿namespace Parcial0220200043.API.Models
{
    public interface ITerritoryRepository
    {
        Task<bool> Delete(int id);
        Task<IEnumerable<Territory>> GetTerrytory();
        Task<bool> Insert(Territory territory);
        Task<bool> Update(Territory territory);
    }
}