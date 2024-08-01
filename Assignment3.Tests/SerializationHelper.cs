using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using Assignment3.Utility;

namespace Assignment3.Tests
{
    public static class SerializationHelper
    {
        /// <summary>
        /// Serializes (encodes) users
        /// </summary>
        /// <param name="users">List of users</param>
        /// <param name="fileName"></param>
        public static void SerializeUsers(ILinkedListADT users, string fileName)
        {
            var serializer = new DataContractSerializer(typeof(ILinkedListADT), new Type[] { typeof(SLL), typeof(User) });
            using (var stream = new FileStream(fileName, FileMode.Create))
            {
                serializer.WriteObject(stream, users);
            }
        }

        public static ILinkedListADT DeserializeUsers(string fileName)
        {
            var serializer = new DataContractSerializer(typeof(ILinkedListADT), new Type[] { typeof(SLL), typeof(User) });
            using (var stream = new FileStream(fileName, FileMode.Open))
            {
                return (ILinkedListADT)serializer.ReadObject(stream);
            }
        }
    }
}
