using System;
using System.Collections.Generic;


namespace Bottom_Class
{
    public class Order:IComparable
    {
        public int Id { get; set; }//编号
        public int CustomerId { get; set; }//顾客编号，作为外键
        public Customer Customer { get; set; }//顾客
        public List<OrderItem> OrderItems { get; set; }//订单项
        public int TotalPrice { get; set; }//总价
        public string OrderTime { get; set; }//下单时间
        public string OrderState { get; set; }//订单状态
        public int MerchantId { get; set; }
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object obj)
        {
            return obj is Order order &&
                   Id == order.Id &&
                   CustomerId == order.CustomerId &&
                   EqualityComparer<Customer>.Default.Equals(Customer, order.Customer) &&
                   EqualityComparer<List<OrderItem>>.Default.Equals(OrderItems, order.OrderItems) &&
                   TotalPrice == order.TotalPrice &&
                   OrderTime == order.OrderTime &&
                   OrderState == order.OrderState;
        }

        public override int GetHashCode()
        {
            int hashCode = 1218412534;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + CustomerId.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<Customer>.Default.GetHashCode(Customer);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<OrderItem>>.Default.GetHashCode(OrderItems);
            hashCode = hashCode * -1521134295 + TotalPrice.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(OrderTime);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(OrderState);
            return hashCode;
        }
    }
}
