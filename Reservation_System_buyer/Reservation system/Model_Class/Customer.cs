using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace Reservation_system.Model_Class
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

    }
}
