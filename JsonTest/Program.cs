using System.Text.Json;
using System.Text.Json.Serialization;

namespace JsonTest
{
    public class JsonData
     {
         public string? input { get; set; }
     }
    
    public class Program
    {
        public static void Main(string[] args)
        {
            string input;
            string jsonString;
            
            if (File.Exists("Input.json"))
            {
                jsonString = File.ReadAllText("Input.json");
                JsonData jsonData = JsonSerializer.Deserialize<JsonData>(jsonString);
                Console.WriteLine($"{jsonData?.input}");
            }

            else
            {
                input = Console.ReadLine();
                var JsonData = new JsonData
                {
                    input = input
                };
                jsonString = JsonSerializer.Serialize(JsonData);
    
                Console.WriteLine(jsonString);
                File.WriteAllText("Input.json", jsonString);
            }
            
        }
    }

    
}
