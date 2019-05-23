using PlantATree.Middleware.DatabaseManagement;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantATree.Models
{
    public class UserCart
    {

        public Dictionary<String, int> cart;
        public List<PlantInfo> plants;

        public UserCart()
        {
            cart = new Dictionary<String, int>();
            plants = new PlantSearchDbm().GetAllPlants();
        }

        public void AddItem(String p)
        {
            string plantName = p;
            int Quantity = 1;

            if (cart.ContainsKey(plantName))
            {
                cart.TryGetValue(plantName, out Quantity);
                cart.Remove(plantName);
                ++Quantity;
                cart.Add(plantName, Quantity);
            }
            else
            {
                cart.Add(plantName, 1);
            }
        }

        public void RemoveItem(String p)
        {
            string plantName = p;
            int Quantity = 1;

            if (cart.ContainsKey(plantName))
            {
                cart.TryGetValue(plantName, out Quantity);
                cart.Remove(plantName);
                
                if(Quantity >= 2)
                {
                    --Quantity;
                    cart.Add(plantName, Quantity);
                }
                
            }
        }

        public List<CartItem> GetCartItems()
        {
            List<CartItem> RetCart = new List<CartItem>();

            CartItem TmpItem;

            foreach (KeyValuePair<String, int> i in cart)
            {
                TmpItem = new CartItem();

                foreach(PlantInfo p in plants)
                {
                    if (p.Name.Equals(i.Key))
                    {
                        TmpItem.Plant = p;
                        TmpItem.Quantity = i.Value;
                    }
                }

                if(!TmpItem.Equals(new CartItem())){
                    RetCart.Add(TmpItem);
                }
            }

            return RetCart;            
        }
    }
}
