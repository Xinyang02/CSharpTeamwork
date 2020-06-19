using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Bottom_Class
{
    public class OrderItem
    {
        public int Id { get; set; }//编号
        public int CuisineId { get; set; }//菜品编号，作为外键
        public Cuisine Cuisine { get; set; }//菜品
        public string CuisineName { get; set; }//菜品名
        public int OrderId { get; set; }//订单编号，作为引用
        [JsonIgnore]
        [IgnoreDataMember]
        public Order Order { get; set; }//订单
        public int Amount { get; set; }//数量

        public override bool Equals(object obj)
        {
            return obj is OrderItem item &&
                   Id == item.Id &&
                   CuisineId == item.CuisineId &&
                   EqualityComparer<Cuisine>.Default.Equals(Cuisine, item.Cuisine) &&
                   OrderId == item.OrderId &&
                   EqualityComparer<Order>.Default.Equals(Order, item.Order) &&
                   Amount == item.Amount;
        }

        public override int GetHashCode()
        {
            int hashCode = -1119478081;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + CuisineId.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Cuisine>.Default.GetHashCode(Cuisine);
            hashCode = hashCode * -1521134295 + OrderId.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Order>.Default.GetHashCode(Order);
            hashCode = hashCode * -1521134295 + Amount.GetHashCode();
            return hashCode;
        }
    }
}
