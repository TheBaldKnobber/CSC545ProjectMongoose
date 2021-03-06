﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GroupProject545
{
    class RecipePost
    {
        [JsonProperty("category")]
        public string category { get; set; }
        [JsonProperty("ingredients")]
        public List<int> ingredients_post { get; set; }
        [JsonProperty("instructions")]
        public string instructions { get; set; }
        [JsonProperty("rec_id")]
        public int rec_id { get; set; }
        [JsonProperty("rec_name")]
        public string rec_name { get; set; }

        public RecipePost() {
            this.ingredients_post = new List<int>();
        }
        public void CreateRecipe()
        {
            var recipe = new {recipes=new List<RecipePost>()};
            recipe.recipes.Add(this);
            string json = JsonConvert.SerializeObject(recipe);
            string endpoint = "http://mongoose.theerroris.me/recipe/";
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(endpoint);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            var jsonString = (new StreamReader(httpResponse.GetResponseStream())).ReadToEnd();
            Console.WriteLine(jsonString);
            Console.ReadLine();
        }
    }
}
