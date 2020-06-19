using System;
using System.Collections.Generic;
using System.Text;

namespace Reservation_system.Model_Class
{
    public class Merchant
    {
        public int Id { get; set; }//编号
        public string Name { get; set; }//名称
        public string Password { get; set; }//密码
        public string PhoneNum { get; set; }//电话号码
        public string Address { get; set; }//地址
        public string BusinessHours { get; set; }//营业时间
        public int Balance { get; set; }//余额
        public byte[] Picture { get; set; }//商家图片
        public List<CuisineType> CuisineTypes { get; set; }//作为外键，包含该商家的所有菜品类型
    }
}
