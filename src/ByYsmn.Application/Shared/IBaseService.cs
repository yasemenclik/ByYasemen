using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ByYsmn.Application.Shared
{
    public interface IBaseService<TPKey, TCreateInput, TUpdateInput, TModel>
    {
        Task <List<TModel>> GetAll();
        Task <List<TModel>> GetAllByUserId(Guid userId);
        Task <List<TModel>> GetAllByKeyWord(string input);
        Task <TModel> GetAsync(EntityInput<TPKey> input);
        Task <TModel> CreateAsync(TCreateInput input);
        Task <TModel> Update(TUpdateInput input);
        Task <TModel> Delete(EntityInput<TPKey> input);
    }
}
