using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace GroupProject545
{
    class Fridge
    {
        [JsonProperty("fk_nfact_id")]
        public int fk_nfact_id { get; set; }
        [JsonProperty("food_id")]
        public int food_id { get; set; }
        [JsonProperty("food_name")]
        public string food_name { get; set; }
        [JsonProperty("in_fridge")]
        public bool in_fridge { get; set; }

        public RootObjectFridge GetAllFridgeItems()
        {
            string endpoint = "http://mongoose.theerroris.me/fridge/";
            Console.WriteLine("Making a json request to " + endpoint);

            var httpWebRequest = (HttpWebRequest)WebRequest.Create(endpoint);
            httpWebRequest.Method = "GET";

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            var jsonString = (new StreamReader(httpResponse.GetResponseStream())).ReadToEnd();
            RootObjectFridge fridge_json = JsonConvert.DeserializeObject<RootObjectFridge>(jsonString);
            foreach (var fridge_item in fridge_json.fridge)
            {
                Console.WriteLine("Food name: " + fridge_item.food_name);
                Console.WriteLine("Food id: " + fridge_item.food_id);
                Console.WriteLine("In Fridge: " + fridge_item.in_fridge);
                Console.WriteLine("Nutrition fact id: " + fridge_item.fk_nfact_id);
                Console.WriteLine();
            }
            Console.ReadLine();
            return fridge_json;
        }
    }
}
