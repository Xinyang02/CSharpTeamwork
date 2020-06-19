using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OrderServer.Models;

namespace OrderServer.DAO
{
    public class MerchantService
    {
        private readonly OrderContext orderDB;

        public MerchantService(OrderContext orderContext)
        {
            orderDB = orderContext;
        }

        public Merchant RegisterService(Merchant merchant)
        {
            Merchant failMer = null;
            try
            {
                orderDB.Merchants.Add(merchant);
                orderDB.SaveChanges();
            }
            catch (Exception e)
            {
                return failMer;
            }
            return merchant;
        }

        public Merchant LoginService(Merchant merchant)
        {
            Merchant failMer = null;
            var mer = orderDB.Merchants.Where(op => op.Id == merchant.Id)
                .Where(op => op.Password == merchant.Password).ToList<Merchant>();
            if (mer.Count == 0)
                return failMer;
            merchant = mer[0];
            return mer[0];
        }

        public Merchant SetAccontService(Merchant merchant)
        {
            Merchant failMer = null;
            try
            {
                orderDB.Entry(merchant).State = EntityState.Modified;
                orderDB.SaveChanges();
            }
            catch (Exception e)
            {
                return failMer;
            }
            return merchant;
        }

        public List<CuisineType> GetAllCuisinesService(int id)
        {
            var cuisineTypes = orderDB.CuisineTypes.Include("Cuisines").Where(op => op.MerchantId == id).ToList<CuisineType>();
            List<Cuisine> cuisines = new List<Cuisine>();
            return cuisineTypes;
        }

        public bool AddCisineService(Cuisine cuisine)
        {
            try
            {
                orderDB.Cuisines.Add(cuisine);
                orderDB.SaveChanges();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool DeleteCuisineService(int id)
        {
            var cuisine = orderDB.Cuisines.First(op => op.Id == id);
            try
            {
                orderDB.Cuisines.Remove(cuisine);
                orderDB.SaveChanges();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool SetCuisineService(Cuisine cuisine)
        {
            try
            {
                orderDB.Entry(cuisine).State = EntityState.Modified;
                orderDB.SaveChanges();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public List<Order> GetOrdersService(int id)
        {
            var orders = orderDB.Orders.Include("Customer").Include("OrderItems")
                .Where(op => op.OrderState == "等待商家接单"&&op.MerchantId==id).ToList<Order>();
            foreach(Order order in orders)
                foreach(OrderItem orderItem in order.OrderItems)
                {
                    orderItem.Cuisine = orderDB.Cuisines.First(op => op.Id == orderItem.CuisineId);
                }
            return orders;
        }

        public List<Order> GetAcceptedOrders(int id)
        {
            var orders = orderDB.Orders.Include("Customer").Include("OrderItems")
                .Where(op => op.OrderState == "商家已接单" && op.MerchantId == id).ToList<Order>();
            foreach (Order order in orders)
                foreach (OrderItem orderItem in order.OrderItems)
                {
                    orderItem.Cuisine = orderDB.Cuisines.First(op => op.Id == orderItem.CuisineId);
                }
            return orders;
        }

        //参数为商家id
        public List<Order> GetCanceledOrders(int id)
        {
            var orders= orderDB.Orders.Include("Customer").Include("OrderItems")
                .Where(op => op.OrderState == "订单等待取消" && op.MerchantId == id).ToList<Order>();
            foreach (Order order in orders)
                foreach (OrderItem orderItem in order.OrderItems)
                {
                    orderItem.Cuisine = orderDB.Cuisines.First(op => op.Id == orderItem.CuisineId);
                }
            return orders;
        }

        //参数为待取消订单id
        public bool AgreeCancel(int id)
        {
            var order = orderDB.Orders.First(op => op.Id == id);
            order.OrderState = "订单已取消";
            try
            {
                orderDB.Entry(order).State = EntityState.Modified;
                orderDB.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool FinishDeal(int id, Order order)
        {
            order.OrderState = "商家完成制作，正在派送中";
            try
            {
                orderDB.Entry(order).State = EntityState.Modified;
                Merchant merchant = orderDB.Merchants.Include("CuisineTypes").First(op => op.Id == id);
                merchant.Balance = +order.TotalPrice;
                orderDB.Entry(merchant).State = EntityState.Modified;
                orderDB.SaveChanges();
            }catch(Exception e)
            {
                return false;
            }
            return true;
        }

        public bool AddCuisineTypeService(CuisineType cuisineType)
        {
            try
            {
                orderDB.CuisineTypes.Add(cuisineType);
                orderDB.SaveChanges();
            }catch(Exception e)
            {
                return false;
            }
            return true;
        }

        public bool TakeAnOrderService(Order order)
        {
            try
            {
                order.OrderState = "商家已接单";
                orderDB.Entry(order).State = EntityState.Modified;
                orderDB.SaveChanges();
            }catch(Exception e)
            {
                return false;
            }
            return true;
        }

        public List<Order> GetDeliveryOrder(int id)
        {
            var orders = orderDB.Orders.Include("Customer").Include("OrderItems")
                .Where(op => op.OrderState == "商家完成制作，正在派送中" && op.MerchantId == id).ToList<Order>();
            foreach (Order order in orders)
                foreach (OrderItem orderItem in order.OrderItems)
                {
                    orderItem.Cuisine = orderDB.Cuisines.First(op => op.Id == orderItem.CuisineId);
                }
            return orders;
        }

        public List<Order> GetFinishedOrders(int id)
        {
            var orders = orderDB.Orders.Include("Customer").Include("OrderItems")
                .Where(op => op.OrderState == "确认收货，订单完成" && op.MerchantId == id).ToList<Order>();
            foreach (Order order in orders)
                foreach (OrderItem orderItem in order.OrderItems)
                {
                    orderItem.Cuisine = orderDB.Cuisines.First(op => op.Id == orderItem.CuisineId);
                }
            return orders;
        }
    }
}
