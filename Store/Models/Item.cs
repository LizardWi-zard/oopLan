using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.models
{
    public class Item
    {
        public Item(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public int Id { get; }

        public string Name { get; }

        public string Description { get; }

        public static (Item item, string Error) Create(int id, string name, string description)
        {
            var error = string.Empty;

            var item = new Item(id, name, description);

            return (item, error);
        }
    }
}
