using System;
using System.Collections.Generic;
using Enumeracao.Entites.Enums;

namespace Enumeracao.Entites
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }

        public OrderStatus Status { get; set; }

        public Order(int id, DateTime moment, OrderStatus status)
        {
            Id = id;
            Moment = moment;
            Status = status;
        }

        public override string ToString()
        {
            return $"Product ID: {Id} | Purchase Date: {Moment} | Order Status: {Status}";
        }
    }
}
