

using Microsoft.EntityFrameworkCore;
using Store.models;

namespace Store.DataAccess.Reposetory
{
    public class ItemRepository
    {
        private readonly StoreDBContext _context;

        public ItemRepository(StoreDBContext context)
        {
            _context = context;
        }

        public async Task<List<Item>> Get()
        {
            var itemEntities = await _context.Items.ToListAsync();

            var items = itemEntities
                .Select(b => Item.Create(b.Id, b.Name, b.Description).item)
                .ToList();

            return items;
        }

    }
}
