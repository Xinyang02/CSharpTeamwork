using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OrderServer.Models
{
    public class CuisineType
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public List<Cuisine> Cuisines { get; set; }
        public int MerchantId { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public Merchant Merchant { get; set; }
    }
}
