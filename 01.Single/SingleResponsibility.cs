using System;
using System.Collections.Generic;

namespace SolidExamples
{
    public class SingleResponsibility
    {
        private readonly IOrderRepository orderRepository;

        public SingleResponsibility(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }

        public void CreateOrder(Order order)
        {
            if(order.Id != 0)
            {
                throw new ApplicationException("This is not a new order");
            }

            if(order.CustomerId == 0)
            {
                throw new InvalidOperationException("An order must have a customer assigned before creating it.");
            }

            if(order.Items.Count == 0)
            {
                throw new InvalidOperationException("An order must contain at least one item before creating it");
            }

            if(order.OrderTotal <= 0)
            {
                throw new InvalidOperationException("An order cannot have a total value of zero or less.");
            }

            orderRepository.Save(order);
        }
    }

    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public List<OrderItem> Items { get; set; }
        public float OrderTotal { get; set; }
    }

    public class OrderItem { }

    public interface IOrderRepository
    {
        void Save(Order order);
        Order Get(int id);
    }
}
