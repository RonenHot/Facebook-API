using System.Drawing;
using System.IO;
using System.Xml.Serialization;

namespace FacebookSystemApplicationLogic
{
    public sealed class ApplicationSettings
    {
        private const string k_SettingsFilePath = @"C:\Users\Public\ApplicationSettings.xml";
        private static ApplicationSettings s_TheOneAndOnlyInstance = null;

        private ApplicationSettings()
        {
            LastWindowLocation = new Point(0, 0);
            LastWindowSize = new Size(1167, 736);
            RememberUser = false;
            LastAccessToken = null;
        }

        public static ApplicationSettings GetCreateTheOneAndOnlyInstance
        {
            get
            {
                if(s_TheOneAndOnlyInstance == null)
                {
                    s_TheOneAndOnlyInstance = new ApplicationSettings();
                }

                return s_TheOneAndOnlyInstance;
            }
        }

        public Point LastWindowLocation { get; set; }

        public Size LastWindowSize { get; set; }

        public bool RememberUser { get; set; }

        public string LastAccessToken { get; set; }

        public static ApplicationSettings LoadFromFile()
        {
            ApplicationSettings storedAppSettings = new ApplicationSettings();
            if(File.Exists(k_SettingsFilePath))
            {
                using(Stream stream = new FileStream(k_SettingsFilePath, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(ApplicationSettings));
                    storedAppSettings = serializer.Deserialize(stream) as ApplicationSettings;
                }
            }

            return storedAppSettings;
        }

        public void SaveToFile()
        {
            if (File.Exists(k_SettingsFilePath))
            {
                using (Stream stream = new FileStream(k_SettingsFilePath, FileMode.Truncate))
                {
                    XmlSerializer serializer = new XmlSerializer(this.GetType());
                    serializer.Serialize(stream, this);
                }
            }
            else
            {
                using (Stream stream = new FileStream(k_SettingsFilePath, FileMode.CreateNew))
                {
                    XmlSerializer serializer = new XmlSerializer(this.GetType());
                    serializer.Serialize(stream, this);
                }
            }
        }
    }
}
