using Concepts.SerializationDeserialization;
using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Concepts
{
    class Program
    {
        static void Main()
        {
            // in catch block
            // in swith statements
            // swith expression
            //var example1 = new WhenExample1();
            //var returnValue = example1.ProcessInput(9);
            //Console.WriteLine(returnValue);

            // serialization
            var userModel = new UserModel { Id = 1, Name = "Usman" };
            IFormatter formatter = new BinaryFormatter();
            var stream = new FileStream("userinfo.txt", FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, userModel);
            stream.Close();

            var readStream = new FileStream("userinfo.txt", FileMode.Open, FileAccess.Read);
            UserModel model = (UserModel)formatter.Deserialize(readStream);



            Console.ReadKey();
        }
    }
}
