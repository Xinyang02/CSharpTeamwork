using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OrderServer.Models;

namespace OrderServer.DAO
{
    public class CustomerService
    {
        private readonly OrderContext orderDB;

        public CustomerService(OrderContext orderContext)
        {
            orderDB = orderContext;
        }

        public Customer RegisterService(Customer customer)
        {
            Customer failCus = null;
            try
            {
                orderDB.Customers.Add(customer);
                orderDB.SaveChanges();
            }catch(Exception e)
            {
                return failCus;
            }
            return customer;
        }

        public Customer LoginService(Customer customer)
        {
            Customer failCus = null;
            var cus = orderDB.Customers.Where(op => op.Id == customer.Id)
                .Where(op => op.Password == customer.Password).ToList<Customer>();
            if (cus.Count == 0)
                return failCus;
            return cus[0];
        }

        public Customer SetAccountService(Customer customer)
        {
            Customer failCus = null;
            try
            {
                orderDB.Entry(customer).State = EntityState.Modified;
                orderDB.SaveChanges();
            }
            catch (Exception e)
            {
                return failCus;
            }
            return customer;
        }

        public List<Order> GetAllOrdersService(int id)
        {
            var orders = orderDB.Orders.Include("OrderItems").Where(op => op.CustomerId == id).ToList<Order>();
            foreach (Order order in orders)
                foreach (OrderItem orderItem in order.OrderItems)
                    orderItem.Cuisine = orderDB.Cuisines.First(op => op.Id == orderItem.CuisineId);
            return orders;
        }
        public bool AddOrderService(Order order)
        {
            try
            {
                order.OrderState = "等待商家接单";
                orderDB.Orders.Add(order);
                Customer customer = orderDB.Customers.First(op => op.Id == order.CustomerId);
                customer.Balance -= order.TotalPrice;
                orderDB.Entry(customer).State = EntityState.Modified;
                orderDB.SaveChanges();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool FinishOrderService(Order order)
        {
            try
            {
                order.OrderState = "确认收货，订单完成";
                orderDB.Entry(order).State = EntityState.Modified;
                orderDB.SaveChanges();
            }catch(Exception e)
            {
                return false;
            }
            return true;
        }

        public List<Order> GetCurrentOrdersService(int id)
        {
            var orders = orderDB.Orders.Include("OrderItems")
                .Where(op => op.CustomerId == id && (op.OrderState == "等待商家接单" || op.OrderState == "商家完成制作，正在派送中"||op.OrderState== "商家已接单")).ToList<Order>();
            return orders;
        }

        public List<Merchant> GetAllMerchantsService()
        {
            var merchants = orderDB.Merchants.Include("CuisineTypes").Where(op=>op.Id!=null).ToList<Merchant>();
            return merchants;
        }

        public bool CancelOrder(Order order)
        {
            var order1 = orderDB.Orders.Include("OrderItems").FirstOrDefault(op => op.Id == order.Id);
            if (order1.OrderState != "等待商家接单")
                return false;
            try
            {
                order1.OrderState = "订单等待取消";
                orderDB.Entry(order1).State = EntityState.Modified;
                /*Customer customer = orderDB.Customers.First(op => op.Id == order.CustomerId);
                Console.WriteLine("检查点三");
                customer.Balance += order.TotalPrice;
                orderDB.Entry(customer).State = EntityState.Modified;
                Console.WriteLine("检查点四");*/
                orderDB.SaveChanges();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            return true;
        }
    }
}
