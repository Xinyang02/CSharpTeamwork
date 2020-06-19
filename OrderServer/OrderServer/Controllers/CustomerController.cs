using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderServer.Models;
using Microsoft.EntityFrameworkCore;
using OrderServer.DAO;

namespace OrderServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private CustomerService customerService;
        public CustomerController(OrderContext orderContext)
        {
            customerService = new CustomerService(orderContext);
        }

        //用户注册
        [HttpPost("register")]
        public ActionResult<Customer> Register(Customer customer)
        {
            return customerService.RegisterService(customer);
        }

        //用户登录
        [HttpPost("login")]
        public ActionResult<Customer> Login(Customer customer)
        {
            return customerService.LoginService(customer);
        }

        //用户账号设置
        [HttpPut]
        public ActionResult<Customer> SetAccount(Customer customer)
        {
            return customerService.SetAccountService(customer);
        }

        //获取该用户的所有订单
        [HttpGet("{id}")]
        public ActionResult<List<Order>> GetAllOrders(int id)
        {
            return customerService.GetAllOrdersService(id);
        }

        //订餐
        [HttpPost("addorder")]
        public ActionResult<String> AddOrder(Order order)
        {
            if (!customerService.AddOrderService(order))
                return Content("订餐失败");
            return Content("订餐成功");
        }

        //确认收货
        [HttpPost("finishorder")]
        public ActionResult<String> FinishOrder(Order order)
        {
            if (!customerService.FinishOrderService(order))
                return Content("确认收货失败");
            return Content("交易完成");
        }

        //获取当前所有未完成的订单
        [HttpGet("getcurrentorders/{id}")]
        public ActionResult<List<Order>> GetCurrentOrders(int id)
        {
            return customerService.GetCurrentOrdersService(id);
        }

        //获取所有商家
        [HttpGet("getallmerchants")]
        public ActionResult<List<Merchant>> GetAllMerchants()
        {
            return customerService.GetAllMerchantsService();
        }

        //取消订单
        [HttpPost("cancelorder")]
        public ActionResult<String> CancelOrder(Order order)
        {
            if (!customerService.CancelOrder(order))
                return Content("订单取消失败");
            return Content("订单取消成功");
        }
    }
}