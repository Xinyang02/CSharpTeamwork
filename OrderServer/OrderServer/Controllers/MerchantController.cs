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
    public class MerchantController : ControllerBase
    {
        private MerchantService merchantService;

        public MerchantController(OrderContext orderContext)
        {
            merchantService = new MerchantService(orderContext);
        }

        //商家注册
        [HttpPost]
        public ActionResult<Merchant> Register(Merchant merchant)
        {
            return merchantService.RegisterService(merchant);
        }

        //商家登录
        [HttpPost("login")]
        public ActionResult<Merchant> Login(Merchant merchant)
        {
            return merchantService.LoginService(merchant);
        }

        //商家账号修改
        [HttpPut]
        public ActionResult<Merchant> SetAccount(Merchant merchant)
        {
            return merchantService.SetAccontService(merchant);
        }

        //获取该店所有菜品
        [HttpGet("{id}")]
        public ActionResult<List<CuisineType>> GetAllCuisines(int id)
        {
            return merchantService.GetAllCuisinesService(id);
        }

        //上架新菜品
        [HttpPost("addcuisine")]
        public ActionResult AddCuisine(Cuisine cuisine)
        {
            if (!merchantService.AddCisineService(cuisine))
                return Content("添加失败");
            return Content("添加成功");
        }

        //下架菜品
        [HttpDelete("deletecuisine/{id}")]
        public ActionResult DeleteCuisine(int id)
        {
            if (!merchantService.DeleteCuisineService(id))
                return Content("删除失败");
            return Content("删除成功");
        }

        //修改菜品信息
        [HttpPut("setcuisine")]
        public ActionResult SetCuisine(Cuisine cuisine)
        {
            if (!merchantService.SetCuisineService(cuisine))
                return Content("修改失败");
            return Content("修改成功");
        }

        //获取所有待完成订单，参数是商家id
        [HttpGet("getorders/{id}")]
        public ActionResult<List<Order>> GetOrders(int id)
        {
            return merchantService.GetOrdersService(id);
        }

        //获取等待取消的订单，参数是商家id
        [HttpGet("getcanceledorders/{id}")]
        public ActionResult<List<Order>> GetCanceledOrders(int id)
        {
            return merchantService.GetCanceledOrders(id);
        }

        //获取已经接取的订单，参数是商家id
        [HttpGet("getacceptedorders/{id}")]
        public ActionResult<List<Order>> GetAcceptedOrders(int id)
        {
            return merchantService.GetAcceptedOrders(id);
        }

        //获取配送中的订单，参数是商家id
        [HttpGet("getdeliveryorders/{id}")]
        public ActionResult<List<Order>> GetDeliveryOrders(int id)
        {
            return merchantService.GetDeliveryOrder(id);
        }

        //获取交易成功的订单，参数为商家id
        [HttpGet("getfinishedorders/{id}")]
        public ActionResult<List<Order>> GetFinishedOrders(int id)
        {
            return merchantService.GetFinishedOrders(id);
        }

        //同意取消订单,参数为待取消的订单id
        [HttpPost("agreecancel/{id}")]
        public ActionResult AgreeCancel(int id)
        {
            if (!merchantService.AgreeCancel(id))
                return Content("取消失败");
            return Content("取消成功");
        }

        //完成交易
        [HttpPut("finish/{id}")]
        public ActionResult FinishDeal(int id,Order order)
        {
            if (!merchantService.FinishDeal(id,order))
                return Content("提交失败");
            return Content("提交成功");
        }

        //添加菜品种类
        [HttpPost("addcuisinetype")]
        public ActionResult AddCuisineType(CuisineType cuisineType)
        {
            if (!merchantService.AddCuisineTypeService(cuisineType))
                return Content("添加失败");
            return Content("添加成功");
        }

        //接单
        [HttpPost("takeanorder")]
        public ActionResult TakeAnOrder(Order order)
        {
            if (!merchantService.TakeAnOrderService(order))
                return Content("接单失败");
            return Content("接单成功");
        }
    }

}