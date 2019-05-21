using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using PlantATree.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantATree.Middleware
{
    public static class SessionManager
    {

        public const String LoggedKey = "_LoggedIn";
        public const String AccountKey = "_Account";
        public const String CartKey = "_Cart";

        public static void LogIn(this ISession session)
        {
            session.SetBoolean(LoggedKey, true);
        }

        public static void LogOut(this ISession session)
        {
            session.Remove(LoggedKey);
        }

        public static void AddToCart(this ISession session, string plant)
        {
            UserCart cart = session.GetObject<UserCart>(CartKey);

            cart.AddItem(plant);

            session.SetObject(CartKey, cart);
        }

        public static void RemoveFrom(this ISession session, string plant)
        {
            UserCart cart = session.GetObject<UserCart>(CartKey);

            cart.RemoveItem(plant);

            session.SetObject(CartKey, cart);
        }


        //Helper methods

        public static void SetBoolean(this ISession session, string key, bool value)
        {
            session.Set(key, BitConverter.GetBytes(value));
        }

        public static bool? GetBoolean(this ISession session, string key)
        {
            var value = session.Get(key);

            if (value == null)
            {
                return null;
            }

            return BitConverter.ToBoolean(value, 0);
        }

        public static void SetObject(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T GetObject<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }

    }
}
