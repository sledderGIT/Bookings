using System;
using Newtonsoft.Json;
using Refit;
using System.Collections.Generic;

namespace Bookings.Core
{
    public static class Constants
    {
        public static class API
        {
            public static string BaseUrl => "http://static.dev.cteleport.com:3050";
            public static RefitSettings BaseSettings = new RefitSettings() 
            {
                JsonSerializerSettings = new JsonSerializerSettings()
                {
                    ContractResolver = new UnderscoreContractResolver()
                }
            };
        }
    }
}
