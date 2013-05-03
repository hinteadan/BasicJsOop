using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ModelStore
{
    public interface IStoreModel
    {
        void Store<T>(T modelObject) where T : IAmModel;
        T Fetch<T>(Guid id) where T : IAmModel;
        T Fetch<T>(Func<T, bool> predicate) where T : IAmModel;
        IEnumerable<T> FetchMany<T>(Func<T, bool> predicate) where T : IAmModel;
        IEnumerable<T> FetchAll<T>() where T : IAmModel;
        void Remove(Guid id);
    }
}
