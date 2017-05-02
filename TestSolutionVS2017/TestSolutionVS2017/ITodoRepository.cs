using System.Collections.Generic;
using TestSolutionVS2017.Models;

namespace TestSolutionVS2017
{
    public interface ITodoRepository
    {
        void Add(TodoItem item);
        IEnumerable<TodoItem> GetAll();
        TodoItem Find(long key);
        void Remove(long key);
        void Update(TodoItem item);
    }
}
