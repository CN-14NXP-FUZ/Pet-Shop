using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pet_Shop.model
{
    public class Order
    {
        private string id;
        private string userId;
        private string cartId;
        private string status;
        private string orderType;
        private DateTime timeOrder;
        private CheckoutInfo checkoutInfo;

        public Order(string id, string userId, string cartId, string status, string orderType, DateTime timeOrder, CheckoutInfo checkoutInfo)
        {
            this.id = id;
            this.userId = userId;
            this.cartId = cartId;
            this.status = status;
            this.orderType = orderType;
            this.timeOrder = timeOrder;
            this.checkoutInfo = checkoutInfo;
        }
        
        public string Id { get => id; set => id = value; }
        public string UserId { get => userId; set => userId = value; }
        public string CartId { get => cartId; set => cartId = value; }
        public string Status { get => status; set => status = value; }
        public string OrderType { get => orderType; set => orderType = value; }
        public DateTime TimeOrder { get => timeOrder; set => timeOrder = value; }
        public CheckoutInfo CheckoutInfo { get => checkoutInfo; set => checkoutInfo = value; }
    }
}