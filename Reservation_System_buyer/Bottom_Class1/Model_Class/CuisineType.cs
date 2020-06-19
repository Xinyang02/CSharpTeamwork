using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Bottom_Class
{
    public class CuisineType
    {
        public int Id { get; set; }//编号
        public string TypeName { get; set; }//类型名称
        public List<Cuisine> Cuisines { get; set; }//该菜品类型包含的具体菜品
        public int MerchantId { get; set; }//商家名，作为外键
        [JsonIgnore]
        [IgnoreDataMember]
        public Merchant Merchant { get; set; }//商家

        public CuisineType() 
        {
            Cuisines = new List<Cuisine>();
        }
    }
}
