using Newtonsoft.Json;
using System.IO;

namespace MakeMyTrip.Data
{
    public class UserData
    {
        public string email;
        public string password;
        public string json;
        public UserData() 
        { 
            using (StreamReader reader = new StreamReader("C:\\Users\\HP\\source\\data\\Credentials.json"))
            { 
                json = reader.ReadToEnd(); 
            } 
            
            dynamic b = JsonConvert.DeserializeObject(json); 
            email = b["email"]; 
            password = b["password"];
        } 
    }
}
