using System;
using System.Collections.Generic;
using System.Text;

namespace Reservation_system.Model_Class
{
    public class Order
    {
        public int Id { get; set; }//编号
        public int CustomerId { get; set; }//顾客编号，作为外键
        public Customer Customer { get; set; }//顾客
        public List<OrderItem> OrderItems { get; set; }//订单项
        public int TotalPrice { get; set; }//总价
        public string OrderTime { get; set; }//下单时间
        public string OrderState { get; set; }//订单状态
    }
}
