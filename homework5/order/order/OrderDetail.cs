using System;

namespace OrderManagement
{
    class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public Goods Goods { get; set; }
        public int Quantity { get; set; }
        public double Amount => Goods.Price * Quantity;

        public OrderDetail(int orderDetailId, Goods goods, int quantity)
        {
            OrderDetailId = orderDetailId;
            Goods = goods;
            Quantity = quantity;
        }

        public override bool Equals(object obj)
        {
            var detail = obj as OrderDetail;
            return detail != null && OrderDetailId == detail.OrderDetailId;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(OrderDetailId);
        }

        public override string ToString()
        {
            return $"OrderDetailId:{OrderDetailId}, Goods:{Goods}, Quantity:{Quantity}, Amount:{Amount}";
        }
    }
}

