namespace OrderManagement
{
    class Goods
    {
        public int GoodsId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Goods(int goodsId, string name, double price)
        {
            GoodsId = goodsId;
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"GoodsId:{GoodsId}, Name:{Name}, Price:{Price}";
        }
    }
}

