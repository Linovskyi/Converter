using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CurrencyLib
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class CurrencyRate
    {
        [JsonProperty(PropertyName = "r030")]
        public int r030 { get; set; }

        [JsonProperty(PropertyName = "txt")]
        public string txt { get; set; }

        [JsonProperty(PropertyName = "rate")]
        public float rate { get; set; }

        [JsonProperty(PropertyName = "cc")]
        public string cc { get; set; }

        [JsonProperty(PropertyName = "exchangedate")]
        public string exchangedate { get; set; }

        public string[] ToStringArray()
        {
            string[] arr = new string[] { r030.ToString(), txt, rate.ToString(), cc };

          return arr;
        }
    }
}
