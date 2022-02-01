using System.Collections.Generic;

namespace VisualStudioLauncher.WPF.Store.Interfaces
{
    public interface IBaseStore<T>
    {
        List<T> GetAll();
        T Get(int id);
        int InsertOrUpdate(T item);
        void Delete(int id);
    }
}
