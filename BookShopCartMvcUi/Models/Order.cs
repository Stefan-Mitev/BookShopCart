﻿using Microsoft.Build.Framework;
using NuGet.Protocol;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace BookShopCartMvcUi.Models
{
    [Table("Order")]
    public class Order
    {
        public int Id { get; set; }
        [Required]
        public string UserId { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.UtcNow;
        [Required]
        public int OrderStatusId { get; set; }
        public bool IsDeleted { get; set; } = false;
        public OrderStatus OrderStatus { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
