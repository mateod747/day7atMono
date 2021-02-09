﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Model.Common;
using Model;

namespace Repository.Common
{
    public interface IPepperRepository
    {
        Task<string> SavePepperAsync(PepperModel model);
        Task<List<IModel>> GetAllPeppersAsync();
        Task<int> UpdatePepperAsync(PepperModel model);
        Task<int> DeletePepperAsync(int id);
    }
}
