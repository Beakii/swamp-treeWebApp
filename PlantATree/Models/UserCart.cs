using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantATree.Models
{
    public class UserCart
    {

        public Dictionary<String, int> cart;

        public UserCart()
        {
            cart = new Dictionary<String, int>();
        }

        public void AddItem(String p)
        {
            string plantName = p;
            int quantity = 1;

            if (cart.ContainsKey(plantName))
            {
                cart.TryGetValue(plantName, out quantity);
                cart.Remove(plantName);
                ++quantity;
                cart.Add(plantName, quantity);
            }
            else
            {
                cart.Add(plantName, 1);
            }
        }

        public void RemoveItem(String p)
        {
            string plantName = p;
            int quantity = 1;

            if (cart.ContainsKey(plantName))
            {
                cart.TryGetValue(plantName, out quantity);
                cart.Remove(plantName);
                
                if(quantity >= 2)
                {
                    --quantity;
                    cart.Add(plantName, quantity);
                }
                
            }
        }

    }
}
