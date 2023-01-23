﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryAggregator.DataLayer.Repository.IRepository
{
    public interface IRepository<T>
        where T : class
    {
        Task<IEnumerable<T>> GetList(); // получение всех объектов
        Task<T> Get(int id); // получение одного объекта по id
        void Create(T item); // создание объекта
        void Update(int id); // обновление объекта
        void Delete(int id); // удаление объекта по id
        void Save();  // сохранение изменений
    }
}