using System;
using System.IO;

namespace PassKeeper.Services
{
    public static class FileManagerService
    {
        public static void WriteStringToFile(String file, String path)
        {
            using (StreamWriter wr = new StreamWriter(path, false))
            {
                wr.Write(file);
                wr.Close();
            }
        }

        public static String ReadStringFromFile(String path)
        {
            return File.ReadAllText(path);
        }
    }
}