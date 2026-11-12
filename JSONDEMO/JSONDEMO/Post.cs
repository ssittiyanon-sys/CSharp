using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace JSONDEMO
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(myJsonResponse);
    public class Post
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }



}
