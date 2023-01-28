﻿using LibraryAggregator.DataLayer.Repository;
using LibraryAggregator.DataLayer.Repository.IRepository;

namespace LibraryAggregator.API.Extensions
{
    public static class AddRepositoryDependeciesExtensions
    {
        public static void AddRepositoryDependecies(this IServiceCollection services)
        {
            services.AddScoped<IAuthorRepository, AuthorRepository>();
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<IGenreRepository, GenreRepository>();
        }
    }
}