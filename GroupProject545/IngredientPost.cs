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
    class IngredientPost
    {
        [JsonProperty("food_id")]
        public int food_id { get; set; }
    }
}
