using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace Bottom_Class
{
    public class Merchant_Service
    {
        public static Merchant Login(int id, string password)
        {
            string baseUrl = @"https://localhost:5001/api/merchant/login";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            Merchant merchant = new Merchant() { Id = id, Password = password };
            HttpContent content = new StringContent(JsonConvert.SerializeObject(merchant), Encoding.UTF8, "application/json");
            var task = client.PostAsync(baseUrl, content);
            task.Wait();
            return JsonConvert.DeserializeObject<Merchant>(task.Result.Content.ReadAsStringAsync().Result);//返回完整的商家对象
        }//登录

        public static Merchant Register(int id, string password)
        {
            string baseUrl = @"https://localhost:5001/api/merchant/register";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            Merchant merchant = new Merchant() { Id = id, Password = password };
            HttpContent content = new StringContent(JsonConvert.SerializeObject(merchant), Encoding.UTF8, "application/json");
            var task = client.PostAsync(baseUrl, content);
            task.Wait();
            return JsonConvert.DeserializeObject<Merchant>(task.Result.Content.ReadAsStringAsync().Result);//返回注册结果的对象
        }//注册

        public static void ModifyMerchant(Merchant merchant)
        {
            string baseUrl = @"https://localhost:5001/api/merchant/";
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpContent content = new StringContent(JsonConvert.SerializeObject(merchant), Encoding.UTF8, "application/json");
            var task = client.PostAsync(baseUrl, content);
            task.Wait();

        }//修改商家

        public static List<CuisineType> getAllCuisineTypes(Merchant merchant)
        {
            string baseUrl = @"https://localhost:5001/api/merchant/"+merchant.Id;
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var task = client.GetStringAsync(baseUrl);
            task.Wait();
            return JsonConvert.DeserializeObject<List<CuisineType>>(task.Result);

        }

    }
}
