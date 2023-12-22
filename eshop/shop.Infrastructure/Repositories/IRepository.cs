﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.Infrastructure.Repositories
{
    public interface IRepository<T>
    {
        IEnumerable<T> Get();
        T GetById(int id);

        void Create(T entity);
        void Update(T entity);
        void Delete(int id);

    }
}
