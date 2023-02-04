﻿using LibraryAggregator.DataLayer.Entities;

namespace LibraryAggregator.DataLayer.Repository.IRepository
{
    public interface ILibraryRepository : IRepository<Library>
    {
        Task<List<Library>> GetAllFullInfoLibrariesAsync();
    }
}