using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Services
{
    public interface IToDoListService<T, TColor> where TColor : class
    {
        Task<Item<T, TColor>> AddAsync(Item<T, TColor> item);

        Task DeleteAsync(Item<T, TColor> item);

        Task EditAsync(Item<T, TColor> item);

        Task<Item<T, TColor>> GetItem(T id);

        Task<IEnumerable<Item<T, TColor>>> GetItemsAsync(
            OrderBy orderBy = OrderBy.None,
            int offset = 0,
            int limit = 10,
            bool? completed = null,
            TColor colorFilter = null,
            string titleFilter = null
        );
    }
}
