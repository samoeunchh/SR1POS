using System;

namespace SR1POS.Models
{
    public class SaleDetail
    {
        public Guid SaleDetailId { get; set; }
        public Guid SaleId { get; set; }
        public Guid ProductId { get; set; }
        public Guid UnitId { get; set; }
        public double Price { get; set; }
        public double Amount { get; set; }
        public double Discount { get; set; }
        public double Total { get; set; }
    }
}
