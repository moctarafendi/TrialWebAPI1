﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrialWebAPI1.Entity;

namespace TrialWebAPI1.IService
{
    public interface ICategoryRepository
    {
        Task<List<Category>> GetAll();
        Task<Category> GetById(int id);

    }
}
