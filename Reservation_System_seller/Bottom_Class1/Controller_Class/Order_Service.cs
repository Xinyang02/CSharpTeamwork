using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace Bottom_Class
{
    public class Order_Service
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

        static  public List<Order> GetOrderList(Merchant merchant)
        {
            string baseUrl = @"https://localhost:5001/api/merchant/getorders/"+merchant.Id;
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
         
            var task = client.GetStringAsync(baseUrl);
            task.Wait();
            return JsonConvert.DeserializeObject<List<Order>>(task.Result);
        }//获取待完成订单
        static public List<Order> GetAcceptedOrderList(Merchant merchant)
        {
            string baseUrl = @"https://localhost:5001/api/merchant/getacceptedorders/" + merchant.Id;
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var task = client.GetStringAsync(baseUrl);
            task.Wait();
            return JsonConvert.DeserializeObject<List<Order>>(task.Result);
        }//获取商家已经接受的订单

        static public List<Order> GetWaitCancelOrderList(Merchant merchant)
        {
            string baseUrl = @"https://localhost:5001/api/merchant/getcanceledorders/" + merchant.Id;
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var task = client.GetStringAsync(baseUrl);
            task.Wait();
            return JsonConvert.DeserializeObject<List<Order>>(task.Result);
        }//获取待取消订单

        static public List<Order> GetCancelOrderList(Merchant merchant)
        {
            string baseUrl = @"https://localhost:5001/api/merchant/getcanceledorders/" + merchant.Id;
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var task = client.GetStringAsync(baseUrl);
            task.Wait();
            return JsonConvert.DeserializeObject<List<Order>>(task.Result);
        }//获取已取消订单

        static public List<Order> GetDeliverOrderList(Merchant merchant)
        {
            string baseUrl = @"https://localhost:5001/api/merchant/getdeliveryorders/" + merchant.Id;
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var task = client.GetStringAsync(baseUrl);
            task.Wait();
            return JsonConvert.DeserializeObject<List<Order>>(task.Result);
        }//获取已取消订单

        static public List<Order> GetFinishOrderList(Merchant merchant)
        {
            string baseUrl = @"https://localhost:5001/api/merchant/getfinishedorders/" + merchant.Id;
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var task = client.GetStringAsync(baseUrl);
            task.Wait();
            return JsonConvert.DeserializeObject<List<Order>>(task.Result);
        }//获取已取消订单
    }
}
