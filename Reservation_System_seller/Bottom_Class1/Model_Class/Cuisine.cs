using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;


namespace Bottom_Class
{
    public class Cuisine
    {
        public int Id { get; set; }//编号
        public string Name { get; set; }//名称
        public string Description { get; set; }//菜品描述
        public int UnitPrice { get; set; }//单价
        public byte[] Picture { get; set; }//图片
        public int CuisineTypeId { get; set; }//菜品类型编号，作为外键
        public Cuisine(string name,string des,int price,int typeID,string path)
        {
            //Id = id;
            Name = name;
            Description = des;
            UnitPrice=price;
            CuisineTypeId = typeID;
            Picture = File.ReadAllBytes(path);
        }

        //[JsonIgnore]
        //[IgnoreDataMember]
        public Cuisine()
        {
            
        }

    }
}
