using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace Bottom_Class
{
    public class OrderService
    {
        public void DeleteOrder(Order order)
        {

        }//删除订单
   
        static public void SubmitOrder(Order order)
        {
            string baseUrl = @"https://localhost:5001/api/order/add";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));          
            HttpContent content = new StringContent(JsonConvert.SerializeObject(order), Encoding.UTF8, "application/json");
            var task = client.PostAsync(baseUrl, content);
            task.Wait();
        }//添加订单

        static  public List<Order> GetOrderList(string Id, Order order)
        {
            string baseUrl = @"https://localhost:5001/api/order/";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
         
            var task = client.GetStringAsync(baseUrl);
            task.Wait();
            return JsonConvert.DeserializeObject<List<Order>>(task.Result);
        }//修改订单状态
    }
}
