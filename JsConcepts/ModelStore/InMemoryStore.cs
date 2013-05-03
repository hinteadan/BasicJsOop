using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ModelStore
{
    public class InMemoryStore : IStoreModel
    {
        private readonly Dictionary<Guid, IAmModel> store;

        public InMemoryStore()
        {
            this.store = new Dictionary<Guid, IAmModel>();
            Store(new Contact("Hintee", "Cel Fin"));
        }

        public void Store<T>(T modelObject) where T : IAmModel
        {
            CheckNull(modelObject);

            if (store.ContainsKey(modelObject.Id))
            {
                store[modelObject.Id] = modelObject;
            }
            else
            {
                store.Add(modelObject.Id, modelObject);
            }
        }

        public T Fetch<T>(Guid id) where T : IAmModel
        {
            return (T)store.Single(d => d.Key == id).Value;
        }

        public T Fetch<T>(Func<T, bool> predicate) where T : IAmModel
        {
            return (T)store.Single(d => predicate((T)d.Value)).Value;
        }

        public IEnumerable<T> FetchMany<T>(Func<T, bool> predicate) where T : IAmModel
        {
            return store.Where(d => predicate((T)d.Value)).Select(d => (T)d.Value).ToArray();
        }

        public IEnumerable<T> FetchAll<T>() where T : IAmModel
        {
            return store.Select(d => (T)d.Value).ToArray();
        }

        public void Remove(Guid id)
        {
            store.Remove(id);
        }

        private void CheckNull(IAmModel modelObject)
        {
            if (modelObject == null || modelObject.Id == Guid.Empty)
            {
                throw new ArgumentNullException();
            }
        }
    }
}
