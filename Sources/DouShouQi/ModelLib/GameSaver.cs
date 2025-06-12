using DouShouQiModel;
using System.Runtime.Serialization;
using System.Diagnostics;
using System.Xml.Serialization;
using Serialize;

namespace DouShouQiModel
{
    public class GameSaver : ISerialize
    {
        private static readonly string filePath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "DouShouQi", "Data");

        private const string xmlFile = "ScoreSaves.xml";
        private readonly string path = Path.Combine(filePath, xmlFile);

        public GameSaver()
        {
            try
            {
                if (!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error creating directory: {ex.Message}");
            }
        }
        public T? Load<T>()
        {
            if (!File.Exists(path) || new FileInfo(path).Length == 0)
                return default;

            try
            {
                using FileStream stream = new(path, FileMode.Open);
                XmlSerializer serializer = new(typeof(T));
                var result = serializer.Deserialize(stream);
                if (result is null) return default;
                return (T)result;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error loading file: {ex.Message}");
                return default;
            }
        }
        public void Save<T>(T data)
        {
            try
            {
                using FileStream stream = new(path, FileMode.Create);
                XmlSerializer serializer = new(typeof(T));
                serializer.Serialize(stream, data);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error saving file: {ex.Message}");
            }
        }
    }

}
