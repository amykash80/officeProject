using StreamlineAcademy.Application.RRModels;
using StreamlineAcademy.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StreamlineAcademy.Application.Abstractions.IRepositories
{
    public interface IAuthRepository
    {
        #region async methods
        Task<int> InsertAsync<T>(T model) where T : BaseModel;
        Task<int> InsertRangeAsync<T>(List<T> model) where T : BaseModel;

        Task<int> UpdateAsync<T>(T model) where T : BaseModel;

        Task<int> DeleteAsync<T>(T model) where T : BaseModel;

        //Task<IEnumerable<T>> GetAllAsync() where T : BaseModel;

        //Task<IEnumerable<T>> FindByAsync(Expression<Func<T, bool>> expression);

        //Task<T> GetByIdAsync(Expression<Func<T, bool>> expression);

        //Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> expression);

        #endregion

    }
}
