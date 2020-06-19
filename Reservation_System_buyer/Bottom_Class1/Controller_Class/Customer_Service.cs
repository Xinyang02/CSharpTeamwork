using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using System.Drawing.Design;

namespace Bottom_Class
{
    public class Customer_Service
    {
        public static Customer Login(int id ,string password)
        {
      
                string baseUrl = @"https://localhost:5001/api/customer/login";
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                Customer customer = new Customer() { Id = id, Password = password };
                HttpContent content = new StringContent(JsonConvert.SerializeObject(customer), Encoding.UTF8, "application/json");
                var task = client.PostAsync(baseUrl, content);
                task.Wait();
                return JsonConvert.DeserializeObject<Customer>(task.Result.Content.ReadAsStringAsync().Result);//返回完整的顾客对象
            

        }//登录

        public static Customer Register(int id,string password)
        {
            string baseUrl = @"https://localhost:5001/api/customer/register";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            Customer customer = new Customer() { Id = id, Password = password };
            HttpContent content = new StringContent(JsonConvert.SerializeObject(customer), Encoding.UTF8, "application/json");
            var task = client.PostAsync(baseUrl, content);
            task.Wait();
            return JsonConvert.DeserializeObject<Customer>(task.Result.Content.ReadAsStringAsync().Result);//返回注册结果的对象
        }//注册

        public static void ModifyCustomer(Customer customer)
        {
            string baseUrl = @"https://localhost:5001/api/customer/";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpContent content = new StringContent(JsonConvert.SerializeObject(customer), Encoding.UTF8, "application/json");
            var task = client.PutAsync(baseUrl, content);
            task.Wait();
            
        }//修改用户

        public static List<Merchant> GetAllMerchants()
        {
            string baseUrl = @"https://localhost:5001/api/customer/getallmerchants";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));   
            var task = client.GetStringAsync(baseUrl);
            task.Wait();
            return JsonConvert.DeserializeObject<List<Merchant>>(task.Result);
        }//获取所有商家

        static async public Task<String> AddOrder(Order order)
        {
            string baseUrl = @"https://localhost:5001/api/customer/addorder";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpContent content = new StringContent(JsonConvert.SerializeObject(order), Encoding.UTF8, "application/json");
            var task = client.PostAsync(baseUrl, content);
            task.Wait();
            string result = await task.Result.Content.ReadAsStringAsync();
            return result;
        }//添加订单

        static public List<Order> GetAllOrders(int Id)
        {
            string baseUrl = @"https://localhost:5001/api/customer/"+Id;
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var task = client.GetStringAsync(baseUrl);
            task.Wait();
            return JsonConvert.DeserializeObject<List<Order>>(task.Result);
        }//修改订单状态


        static async public Task<String> CancelOrder(Order order)
        {
            string baseUrl = @"https://localhost:5001/api/customer/cancelorder";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpContent content = new StringContent(JsonConvert.SerializeObject(order), Encoding.UTF8, "application/json");
            var task = client.PostAsync(baseUrl, content);
            task.Wait();
            string result = await task.Result.Content.ReadAsStringAsync();
            return result;
        }//删除订单

        static async public Task<String> FinishOrder(Order order)
        {
            string baseUrl = @"https://localhost:5001/api/customer/finishorder";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpContent content = new StringContent(JsonConvert.SerializeObject(order), Encoding.UTF8, "application/json");
            var task = client.PostAsync(baseUrl, content);
            task.Wait();
            string result = await task.Result.Content.ReadAsStringAsync();
            return result;
        }//确认订单



    }
}
