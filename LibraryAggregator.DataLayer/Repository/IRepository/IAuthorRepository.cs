﻿using LibraryAggregator.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAggregator.DataLayer.Repository.IRepository
{
    public interface IAuthorRepository : IRepository<Author>
    {
         Task<List<Author>> GetAllFullInfoAuthorsAsync();
    }
}