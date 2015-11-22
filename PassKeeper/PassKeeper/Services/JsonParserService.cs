using Newtonsoft.Json;
using System;

namespace PassKeeper.Services
{
    public static class JsonParserService
    {
        public static String ParseObjToString(Object objectToParse)
        {
            return JsonConvert.SerializeObject(objectToParse);
        }

        public static T ParseStringToObject<T>(String stringToParse) where T : class
        {
            return JsonConvert.DeserializeObject<T>(stringToParse);
        }
    }
}