﻿using System;
using System.IO;

namespace Server
{
    public static class ConfigHelper
    {
        public static string GetText(string key)
        {
            string path = $"../Nice-Server/Config/{key}.txt";
            try
            {
                string configStr = File.ReadAllText(path);
                return configStr;
            }
            catch (Exception e)
            {
                throw new Exception($"load config file fail, path: {path} {e}");
            }
        }

        public static T ToObject<T>(string str)
        {
            return MongoHelper.FromJson<T>(str);
        }
    }
}
