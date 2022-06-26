using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DigitalEntry.Models;

namespace DigitalEntry.Services
{
    public class MockDataStore : IDataStore<ChildModel>
    {
        readonly List<ChildModel> items;

        public MockDataStore()
        {
            items = new List<ChildModel>()
            {
                
            };
        }

        public async Task<bool> AddItemAsync(ChildModel item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(ChildModel item)
        {
            var oldItem = items.Where((ChildModel arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(int id)
        {
            var oldItem = items.Where((ChildModel arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<ChildModel> GetItemAsync(int id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<ChildModel>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}
