﻿using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Interfaces
{
    public interface IRepository<T>
    {
        public void Add(T entity);
        public bool Contains(T entity);
        public T? Get(string idOrData);
        public ICollection<T>? Get(int optionsRecords);
    }
}
