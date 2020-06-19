using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace Reservation_system.Model_Class
{
    public class OrderItem
    {
        public int Id { get; set; }//编号
        public int CuisineId { get; set; }//菜品编号，作为外键
        public Cuisine Cuisine { get; set; }//菜品
        public int OrderId { get; set; }//订单编号，作为引用
        [JsonIgnore]
        [IgnoreDataMember]
        public Order Order { get; set; }//订单
        public int Amount { get; set; }//数量
    }
}
