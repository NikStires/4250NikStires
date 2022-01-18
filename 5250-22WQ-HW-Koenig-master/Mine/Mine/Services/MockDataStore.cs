using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mine.Models;

namespace Mine.Services
{
    public class MockDataStore : IDataStore<ItemModel>
    {
        readonly List<ItemModel> items;

        public MockDataStore()
        {
            items = new List<ItemModel>()
            {
                new ItemModel { Id = Guid.NewGuid().ToString(), Text = "Ray Gun", Description="Space gun go brrrrrrrrrrrrr.", Value=8},
                new ItemModel { Id = Guid.NewGuid().ToString(), Text = "Hacky Sack", Description="Don't use your hands.", Value=1 },
                new ItemModel { Id = Guid.NewGuid().ToString(), Text = "Sock Monkey", Description="Muffled monkey screeching.", Value=2 },
                new ItemModel { Id = Guid.NewGuid().ToString(), Text = "Ball Point Pen", Description="It's a pen.", Value=10 },
                new ItemModel { Id = Guid.NewGuid().ToString(), Text = "Bubble Wrap", Description="All the bubbles are already popped...", Value=5 },
            };
        }

        public async Task<bool> AddItemAsync(ItemModel item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(ItemModel item)
        {
            var oldItem = items.Where((ItemModel arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((ItemModel arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<ItemModel> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<ItemModel>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}