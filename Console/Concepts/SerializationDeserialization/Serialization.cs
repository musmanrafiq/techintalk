using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

namespace Concepts.SerializationDeserialization
{
    public class Serialization
    {
        public static void XmlSerilization()
        {
            // serialization
            var userModel = new UserModel { Id = 1, Name = "Usman" };
            var formatter = new XmlSerializer(typeof(UserModel));
            var stream = new FileStream("userinfo.xml", FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, userModel);
            stream.Close();

            var readStream = new FileStream("userinfo.xml", FileMode.Open, FileAccess.Read);
            UserModel model = (UserModel)formatter.Deserialize(readStream);
        }

        public static void JsonSerilization()
        {
            var userObject = new UserModel { Id = 2, Name = "Usman Rafiq" };
            var serilizedString = JsonSerializer.Serialize(userObject);
            File.WriteAllText("userinfo.json", serilizedString);

            var readString = File.ReadAllText("userinfo.json");
            var usersObject = JsonSerializer.Deserialize<UserModel>(readString);

        }
    }
}
