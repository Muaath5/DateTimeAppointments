using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DateTimeConverter
{
    public class DataStore
    {
        public static List<Remind> GetList()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            string filePath = GetFilePath();
            FileStream stream = File.OpenRead(filePath);
            try
            {
                return (List<Remind>)formatter.Deserialize(stream);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                stream.Close();
            }
        }

        public static void SaveRemind(Remind remind)
        {
            List<Remind> list = GetList();
            list.Add(remind);

            var formatter = new BinaryFormatter();
            using var stream = File.Open(GetFilePath(), FileMode.Open);
            formatter.Serialize(stream, list);
        }

        public static void SaveListOfRemind(List<Remind> listRemind)
        {
            var formatter = new BinaryFormatter();
            using (var stream = File.Open(GetFilePath(), FileMode.Open))
                formatter.Serialize(stream, listRemind);
        }

        private static string GetFilePath()
        {
            string fileName = Path.Combine(Environment.GetFolderPath(
                Environment.SpecialFolder.ApplicationData), "MuathRemindApp.bin");

            if (!File.Exists(fileName))
            {
                List<Remind> list = new List<Remind>();
                BinaryFormatter formatter = new BinaryFormatter();
                using FileStream stream = File.Open(fileName, FileMode.CreateNew);
                formatter.Serialize(stream, list);
            }

            return fileName;
        }
    }
}
