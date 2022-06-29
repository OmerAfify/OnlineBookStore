using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace OnlineBookStore.Extensions
{
    public static class SessionExtensions
    {
        public static void SetObjectToJson<T>(this ISession session, string key, T value)
            {

            session.SetString(key, JsonConvert.SerializeObject(value, new JsonSerializerSettings()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            }));

            //session.SetString(key, JsonConvert.SerializeObject(value));



        }

            public static T? GetObjectFromJson<T>(this ISession session, string key)
            {
    
            var value = session.GetString(key);
                return value == null ? default : JsonConvert.DeserializeObject<T>(value);
            }
        
    }
}
