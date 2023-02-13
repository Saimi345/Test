using Alachisoft.NCache.Client;

ICache cache = CacheManager.GetCache("test");
cache.Add("1", 1);
Console.WriteLine("Connected");