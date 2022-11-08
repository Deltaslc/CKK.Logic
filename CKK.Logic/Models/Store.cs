using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class Store
    {
        private int _id;
        private string _name;
        private List<StoreItem> Items;

        public Store()
        {
            Items = new List<StoreItem>();
        }

        public int GetId()
        {
            return _id;
        }

        public void SetId(int id)
        {
            _id = id;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public StoreItem AddStoreItem(Product prod, int quantity)
        {
            if (quantity < 0)
            {
                return null;
            }

            //linq query to add item
            var addItem =
                FindStoreItemById(GetId());

            if (addItem == null)
            {
                addItem = new StoreItem(prod, quantity);

                return addItem;
            }
            else
            {
                addItem.SetQuantity(prod.GetId() + quantity);
                return addItem;
            }
            
        }

        public StoreItem RemoveStoreItem(int id, int quantity)
        {
            return null;
        }

        public StoreItem FindStoreItemById(int id) 
        {
            return Items.FirstOrDefault(x => x.GetProduct().GetId() == id);            
        }

        public List<StoreItem> GetStoreItems()
        {
            return Items;
        }
    }
}
