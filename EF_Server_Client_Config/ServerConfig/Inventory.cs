using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServerConfig.Models;

namespace ServerConfig
{
    public class Inventory : IInventory
    {
        public int DbAddItem(string name, int quantity)
        {
            DbInventoryContext context = new DbInventoryContext();
            Item item = new Item { ItemName = name, Quantity = quantity };
            context.Items.Add(item);
            context.SaveChanges();
            return item.ItemId;
        }

        public int DbAddQuantity(int itemId, int quantity)
        {
            DbInventoryContext db = new DbInventoryContext();
            var query = from c in db.Items
                        select c;
            Item item = query.FirstOrDefault(c => c.ItemId == itemId);
            item.Quantity += quantity;
            db.SaveChanges();
            return item.ItemId;
        }

        public int DbSubtractQuantity(int itemId, int quantity)
        {
            return DbAddQuantity(itemId, -quantity);
        }

        public Item DbGetItem(int id)
        {
            DbInventoryContext db = new DbInventoryContext();
            return GetItemFromDbContext(db, id);
        }

        private Item GetItemFromDbContext(DbInventoryContext db, int id)
        {
            var query = from c in db.Items
                        select c;
            Item item = query.FirstOrDefault(c => c.ItemId == id);
            return item;
        }

        public void DbSaveItem(Item newItem)
        {
            DbInventoryContext db = new DbInventoryContext();
            Item item = GetItemFromDbContext(db, newItem.ItemId);
            item.ItemName = newItem.ItemName;
            item.Quantity = newItem.Quantity;
            db.SaveChanges();
        }

        public List<Item> DbGetItems()
        {
            DbInventoryContext db = new DbInventoryContext();
            return db.Items.ToList();
        }

        public void DbRemoveItem(int id)
        {
            DbInventoryContext db = new DbInventoryContext();
            var query = from c in db.Items
                        select c;
            Item item = query.FirstOrDefault(c => c.ItemId == id);
            db.Items.Remove(item);
            db.SaveChanges();
        }

        public void DbClearItems()
        {
            DbInventoryContext db = new DbInventoryContext();
            db.Database.ExecuteSqlCommand("Truncate Table dbo.Items");
        }
    }
}
