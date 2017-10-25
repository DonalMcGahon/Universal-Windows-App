using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace MedicineTracker
{
    public class TodoItem
    {
        public string Id { get; set; }

        [JsonProperty(PropertyName = "complete")]
        public bool Complete { get; set; }

        [JsonProperty(PropertyName = "pName")]
        public string pName { get; set; }

        [JsonProperty(PropertyName = "med")]
        public string Med { get; set; }

        [JsonProperty(PropertyName = "dose")]
        public string Dose { get; set; }

        [JsonProperty(PropertyName = "time")]
        public string Time { get; set; }

        [JsonProperty(PropertyName = "date")]
        public string Date { get; set; }
    }
}
