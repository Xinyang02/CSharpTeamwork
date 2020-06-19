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
        public CuisineType(string name,int MerchantID)
        {
            //this.Id = id;
            this.TypeName = name;
            this.MerchantId = MerchantID;
            Cuisines = new List<Cuisine>();
           // this.Merchant = Merchant;
        }
        public CuisineType()
        {

        }
        public override bool Equals(object obj)
        {
            return obj is CuisineType type &&
                   Id == type.Id &&
                   TypeName == type.TypeName &&
                   EqualityComparer<List<Cuisine>>.Default.Equals(Cuisines, type.Cuisines) &&
                   MerchantId == type.MerchantId &&
                   EqualityComparer<Merchant>.Default.Equals(Merchant, type.Merchant);
        }

        public override int GetHashCode()
        {
            int hashCode = 1120695913;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(TypeName);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<Cuisine>>.Default.GetHashCode(Cuisines);
            hashCode = hashCode * -1521134295 + MerchantId.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Merchant>.Default.GetHashCode(Merchant);
            return hashCode;
        }
    }
}
