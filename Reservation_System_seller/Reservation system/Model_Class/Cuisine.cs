using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace Reservation_system.Model_Class
{
    public class Cuisine
    {
        public int Id { get; set; }//编号
        public string Name { get; set; }//名称
        public string Description { get; set; }//菜品描述
        public int UnitPrice { get; set; }//单价
        public byte[] Picture { get; set; }//图片
        public int CuisineTypeId { get; set; }//菜品类型编号，作为外键
        [JsonIgnore]
        [IgnoreDataMember]
        public CuisineType CuisineType { get; set; }//菜品类型
    }
}
