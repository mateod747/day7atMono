using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Common;
using Model;

namespace Service.Common
{
    public interface IPepperService
    {
        Task<string> SavePepperAsync(IModel model);
        Task<List<IModel>> GetAllPeppersAsync();
        Task<int> UpdatePepperAsync(IModel model);
        Task<int> DeletePepperAsync(int id);
    }
}
