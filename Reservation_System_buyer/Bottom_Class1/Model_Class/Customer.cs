using Newtonsoft.Json;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace Bottom_Class
{
    public class Customer
    {
        public int Id { get; set; }//编号
        public string Name { get; set; }//姓名
        public string Password { get; set; }//密码
        public string PhoneNum { get; set; }//电话号码
        public string Address { get; set; }//地址
        public int Balance { get; set; }//账户余额
        public byte[] Picture { get; set; }//个人图片
        [JsonIgnore]
        [IgnoreDataMember]
        public List<Order> Orders { get; set; }//顾客订单

        public override bool Equals(object obj)
        {
            return obj is Customer customer &&
                   Id == customer.Id &&
                   Name == customer.Name &&
                   Password == customer.Password &&
                   PhoneNum == customer.PhoneNum &&
                   Address == customer.Address &&
                   Balance == customer.Balance &&
                   EqualityComparer<byte[]>.Default.Equals(Picture, customer.Picture) &&
                   EqualityComparer<List<Order>>.Default.Equals(Orders, customer.Orders);
        }

        public override int GetHashCode()
        {
            int hashCode = 1110131486;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Password);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(PhoneNum);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Address);
            hashCode = hashCode * -1521134295 + Balance.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<byte[]>.Default.GetHashCode(Picture);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<Order>>.Default.GetHashCode(Orders);
            return hashCode;
        }
    }
}
