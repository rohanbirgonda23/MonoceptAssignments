using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;

namespace AccountApp
{
    class Account
    {
        public int AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public double Balance { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account
            {
                AccountNumber = 101,
                AccountHolder = "Rohan",
                Balance = 5000
            };

            var options = new JsonSerializerOptions
            {
                TypeInfoResolver = new DefaultJsonTypeInfoResolver()
            };

            string filePath = "account.json";

            string jsonData = JsonSerializer.Serialize(acc, options);
            File.WriteAllText(filePath, jsonData);

            string readData = File.ReadAllText(filePath);
            Account deserializedAcc = JsonSerializer.Deserialize<Account>(readData, options);

            Console.WriteLine(deserializedAcc.AccountNumber);
            Console.WriteLine(deserializedAcc.AccountHolder);
            Console.WriteLine(deserializedAcc.Balance);
        }
    }
}