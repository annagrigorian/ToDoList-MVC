using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoList.Services
{
    public static class ToDoListServiceExtensions
    {
        public static IServiceCollection AddToDoList(this IServiceCollection serviceCollection)
        {
            return serviceCollection.AddScoped<IToDoListService<Guid, string>, ToDoListService>();
        }
    }
}
