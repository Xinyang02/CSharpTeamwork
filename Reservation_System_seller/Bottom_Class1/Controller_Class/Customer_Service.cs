using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Collections.Generic;

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
            var task = client.PostAsync(baseUrl, content);
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
    }
}
