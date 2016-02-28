using System.IO;

namespace RequireVPN
{
    class SettingsHandler
    {
        private static string settingsFileName = "AppSettings.serbin";

        public static ApplicationSettings GetApplicationSetting()
        {
            return (ApplicationSettings)ReadFromBinaryFile(settingsFileName);
        }

        public static void SetApplicationSetting(ApplicationSettings process)
        {
            WriteToBinaryFile(settingsFileName, process);
        }

        private static void WriteToBinaryFile(string filePath, object objectToWrite, bool append = false)
        {
            using (Stream stream = File.Open(filePath, append ? FileMode.Append : FileMode.Create))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                binaryFormatter.Serialize(stream, objectToWrite);
            }
        }

        private static object ReadFromBinaryFile(string filePath)
        {
            using (Stream stream = File.Open(filePath, FileMode.Open))
            {
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                return (object)binaryFormatter.Deserialize(stream);
            }
        }

    }
}
