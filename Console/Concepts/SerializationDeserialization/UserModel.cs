using System;

namespace Concepts.SerializationDeserialization
{
    [Serializable]
    public class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
