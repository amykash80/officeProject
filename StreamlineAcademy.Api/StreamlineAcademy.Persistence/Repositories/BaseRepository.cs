using StreamlineAcademy.Application.Abstractions.IRepositories;
using StreamlineAcademy.Domain.Shared;
using StreamlineAcademy.Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StreamlineAcademy.Persistence.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseModel,new()
    {
        private readonly StreamlineAcademyDbContet context;

        public BaseRepository(StreamlineAcademyDbContet context)
        {
            this.context = context;
        }
        public  Task<int> DeleteAsync(T model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> FindByAsync(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public  Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertAsync(T model)
        {
            throw new NotImplementedException();
        }

        public Task<int> InsertRangeAsync(List<T> model)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(T model)
        {
            throw new NotImplementedException();
        }
    }
}
